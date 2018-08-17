using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class AddUserEvent : HangoutEvent, IAddUserEvent
    {
        public AddUserEvent(DateTime timeStamp, IParticipant sender, string text, string attachment, IParticipant addedUser) : base(timeStamp, sender, text, attachment)
        {
            AddedUser = addedUser ?? throw new ArgumentNullException(nameof(addedUser), $"Parameter {typeof(IParticipant)} {nameof(addedUser)} cannot be null");
        }

        public IParticipant AddedUser { get; }
    }
}
