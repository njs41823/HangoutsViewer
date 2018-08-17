using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class RemoveUserEvent : HangoutEvent, IRemoveUserEvent
    {
        public RemoveUserEvent(DateTime timeStamp, IParticipant sender, string text, string attachment, IParticipant removedUser) : base(timeStamp, sender, text, attachment)
        {
            RemovedUser = removedUser ?? throw new ArgumentNullException(nameof(removedUser), $"Parameter {typeof(IParticipant)} {nameof(removedUser)} cannot be null");
        }

        public IParticipant RemovedUser { get; }
    }
}
