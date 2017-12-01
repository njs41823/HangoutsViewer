namespace HangoutsViewer.Models.Interfaces.HangoutEvents
{
    public interface IRemoveUserEvent : IHangoutEvent
    {
        IParticipant RemovedUser { get; }
    }
}
