using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangoutsViewer.Models.Classes;
using HangoutsViewer.Models.Classes.HangoutEvents;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HangoutsViewer.DataAccess
{
    public static class HangoutsJsonParser
    {
        private const string RenameConversationEventTypeJToken = "RENAME_CONVERSATION";
        private const string VideoChatEventTypeJToken = "HANGOUT_EventTypeJToken";
        private const string RegularChatMessageEventTypeJToken = "REGULAR_CHAT_MESSAGE";
        private const string AddUserEventTypeJToken = "ADD_USER";
        private const string RemoveUserEventTypeJToken = "REMOVE_USER";
        private const string SmsEventTypeJToken = "SMS";
        private const string OnTheRecordModificationEventTypeJToken = "OTR_MODIFICATION";
        private const string VoicemailEventTypeJToken = "VOICEMAIL";

        public static async Task<IHangouts> ParseAsync(FileSystemInfo jsonFileInfo)
        {
            IHangouts result = null;
            await Task.Run(() => { result = Parse(jsonFileInfo); });
            GC.Collect();
            return result;
        }

        private static IHangouts Parse(FileSystemInfo jsonFileInfo)
        {
            using (FileStream fileStream = new FileStream(jsonFileInfo.FullName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                    {
                        return GetHangouts(jsonTextReader);
                    }
                }
            }
        }

        private static IHangouts GetHangouts(JsonReader jsonTextReader)
        {
            Hangouts hangouts = new Hangouts();
            JObject hangoutsJObject = JObject.Load(jsonTextReader);
            JToken rawConvos = hangoutsJObject["conversation_state"];
            for (int convoIndex = 0; convoIndex < rawConvos.Count(); convoIndex++)
            {
                JToken rawConvo = rawConvos[convoIndex];
                JToken innerConvo = rawConvo["conversation_state"]["conversation"];
                JToken innerEvents = rawConvo["conversation_state"]["event"];
                JToken pdata = innerConvo["participant_data"];

                string hangoutType = innerConvo["type"]?.ToString();
                string hangoutName = innerConvo["name"]?.ToString();

                if (string.IsNullOrEmpty(hangoutName)) { hangoutName = "Hangout_" + (convoIndex + 1).ToString().PadLeft(3, '0'); }

                List<IParticipant> hangoutParticipants =
                    (
                        from JToken p
                            in pdata
                        select new Participant(p["id"]["chat_id"].ToString(), p["fallback_name"]?.ToString() ?? "unknown_" + p["id"]["chat_id"]) as IParticipant
                    ).ToList();

                List<IHangoutEvent> hangoutEvents = new List<IHangoutEvent>();
                foreach (JToken innerEvent in innerEvents)
                {
                    JToken messageContent = innerEvent["chat_message"]?["message_content"];
                    JToken messageSegments = messageContent?["segment"];
                    string senderId = innerEvent["sender_id"]["gaia_id"].ToString();
                    DateTime timeStamp =
                        new DateTime(1970, 1, 1).AddSeconds(
                            Convert.ToDouble(innerEvent["timestamp"].ToString().Substring(0, 10)));
                    string eventTypeString = innerEvent["event_type"].ToString();
                    IParticipant sender =
                    (
                        from IParticipant p
                            in hangoutParticipants
                        where p.Id == senderId
                        select p
                    ).DefaultIfEmpty(new Participant(senderId, "unknown_" + senderId)).First();

                    // combine all message segments
                    string allMessageSegments = string.Empty;
                    if (messageSegments != null && messageSegments.Any())
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int sgmntIndex = 0; sgmntIndex < messageSegments.Count(); sgmntIndex++)
                        {
                            JToken sgmnt = messageSegments[sgmntIndex];
                            if (sgmnt?["type"] == null) { continue; }
                            switch (sgmnt["type"].ToString())
                            {
                                case "LINE_BREAK":
                                    sb.Append(Environment.NewLine);
                                    break;
                                default:
                                    if (sgmnt["text"] != null) { sb.Append(sgmnt["text"]); }
                                    break;
                            }
                        }
                        allMessageSegments = sb.ToString();
                    }

                    // combine all attachment segments
                    string attachmentUrl = string.Empty;
                    JToken attachments = messageContent?["attachment"];
                    if (attachments != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int attIndex = 0; attIndex < attachments.Count(); attIndex++)
                        {
                            JToken att = attachments[attIndex];
                            if (att["embed_item"]["type"][0].ToString() != "PLUS_PHOTO") continue;
                            string imgurl = att["embed_item"]["embeds.PlusPhoto.plus_photo"]["url"].ToString();
                            sb.Append(imgurl);
                        }
                        attachmentUrl = sb.ToString();
                    }

                    IHangoutEvent hangoutEvent;
                    switch (eventTypeString)
                    {
                        case RenameConversationEventTypeJToken:
                            string oldName = innerEvent["conversation_rename"]["old_name"].ToString();
                            string newName = innerEvent["conversation_rename"]["new_name"].ToString();
                            hangoutEvent = new RenameConversationEvent(timeStamp, sender, allMessageSegments, attachmentUrl, oldName, newName);
                            break;
                        case VideoChatEventTypeJToken:
                            string eventType = innerEvent["hangout_event"]["event_type"].ToString();
                            switch (eventType)
                            {
                                case "START_HANGOUT":
                                    hangoutEvent = new VideoChatEvent(timeStamp, sender, allMessageSegments, attachmentUrl, VideoChatEventType.StartVideoChat);
                                    break;
                                case "END_HANGOUT":
                                    hangoutEvent = new VideoChatEvent(timeStamp, sender, allMessageSegments, attachmentUrl, VideoChatEventType.EndVideoChat);
                                    break;
                                default:
                                    hangoutEvent = new HangoutEvent(timeStamp, sender, allMessageSegments, attachmentUrl);
                                    break;
                            }
                            break;
                        case RegularChatMessageEventTypeJToken:
                            hangoutEvent = new RegularChatMessageEvent(timeStamp, sender, allMessageSegments, attachmentUrl);
                            break;
                        case AddUserEventTypeJToken:
                            string newUserId = innerEvent["membership_change"]["participant_id"][0]["chat_id"].ToString();
                            string newUserName = (from Participant p in hangoutParticipants where p.Id == newUserId select p.Name).DefaultIfEmpty("unknown_" + newUserId).FirstOrDefault();
                            hangoutEvent = new AddUserEvent(timeStamp, sender, allMessageSegments, attachmentUrl, new Participant(newUserId, newUserName));
                            break;
                        case RemoveUserEventTypeJToken:
                            string removedUserId = innerEvent["membership_change"]["participant_id"][0]["chat_id"].ToString();
                            string removedUserName = (from Participant p in hangoutParticipants where p.Id == removedUserId select p.Name).DefaultIfEmpty("unknown_" + removedUserId).FirstOrDefault();
                            hangoutEvent = new RemoveUserEvent(timeStamp, sender, allMessageSegments, attachmentUrl, new Participant(removedUserId, removedUserName));
                            break;
                        case SmsEventTypeJToken:
                            hangoutEvent = new SmsEvent(timeStamp, sender, allMessageSegments, attachmentUrl);
                            break;
                        case OnTheRecordModificationEventTypeJToken:
                            hangoutEvent = new OnTheRecordModificationEvent(timeStamp, sender, allMessageSegments, attachmentUrl);
                            break;
                        case VoicemailEventTypeJToken:
                            string messageText = "new voicemail";
                            if (allMessageSegments != string.Empty)
                            {
                                messageText = messageText + ":" + Environment.NewLine + allMessageSegments;
                            }
                            hangoutEvent = new VoicemailEvent(timeStamp, sender, messageText, attachmentUrl);
                            break;
                        default:
                            hangoutEvent = new HangoutEvent(timeStamp, sender, allMessageSegments, attachmentUrl);
                            break;
                    }
                    hangoutEvents.Add(hangoutEvent);
                }
                hangoutEvents.Sort((x, y) => x.TimeStamp.CompareTo(y.TimeStamp));
                hangouts.Add(new Hangout(hangoutType, hangoutName, hangoutEvents, hangoutParticipants));
            }
            hangouts.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));
            return hangouts;
        }
    }
}
