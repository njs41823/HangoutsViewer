using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class VideoChatEvent : HangoutEvent, IVideoChatEvent
    {
        public VideoChatEvent(DateTime timeStamp, IParticipant sender, string text, string attachment, VideoChatEventType videoChatEventType) : base(timeStamp, sender, text, attachment)
        {
            VideoChatEventType = videoChatEventType;
        }

        public VideoChatEventType VideoChatEventType { get; }
    }
}
