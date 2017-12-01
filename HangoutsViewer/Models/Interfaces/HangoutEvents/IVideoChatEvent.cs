namespace HangoutsViewer.Models.Interfaces.HangoutEvents
{
    public interface IVideoChatEvent : IHangoutEvent
    {
        VideoChatEventType VideoChatEventType { get; }
    }

    public enum VideoChatEventType
    {
        StartVideoChat,
        EndVideoChat
    }
}
