using System;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes.HangoutEvents
{
    public class HangoutEvent : IHangoutEvent
    {
        public DateTime TimeStamp { get; }

        public IParticipant Sender { get; }

        public string Text { get; }

        public string Attachment { get; }

        public HangoutEvent(DateTime timeStamp, IParticipant sender, string text, string attachment)
        {
            TimeStamp = timeStamp;
            Sender = sender;
            Text = text;
            Attachment = attachment;
        }
    }
}
