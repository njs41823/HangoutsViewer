using System;

namespace HangoutsViewer.Models.Interfaces.HangoutEvents
{
    public interface IHangoutEvent : IModel
    {
        DateTime TimeStamp { get; }

        IParticipant Sender { get; }

        string Text { get; }

        string Attachment { get; }
    }
}
