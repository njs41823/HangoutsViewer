namespace HangoutsViewer.Models.Interfaces.HangoutEvents
{
    public interface IAddUserEvent : IHangoutEvent
    {
        IParticipant AddedUser { get; }
    }
}
