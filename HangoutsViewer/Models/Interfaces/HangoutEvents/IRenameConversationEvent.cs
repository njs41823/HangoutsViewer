namespace HangoutsViewer.Models.Interfaces.HangoutEvents
{
    public interface IRenameConversationEvent : IHangoutEvent
    {
        string OldName { get; }

        string NewName { get; }
    }
}
