using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class SmsEvent : HangoutEvent, ISmsEvent
    {
        public SmsEvent(DateTime timeStamp, IParticipant sender, string text, string attachment) : base(timeStamp, sender, text, attachment)
        {
            
        }
    }
}
