using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class RenameConversationEvent : HangoutEvent, IRenameConversationEvent
    {
        public RenameConversationEvent(DateTime timeStamp, IParticipant sender, string text, string attachment, string oldName, string newName) : base(timeStamp, sender, text, attachment)
        {
            OldName = oldName ?? string.Empty;
            NewName = newName ?? string.Empty;
        }

        public string OldName { get; }

        public string NewName { get; }
    }
}
