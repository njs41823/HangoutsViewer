namespace HangoutsViewer.Models.Interfaces
{
    public interface IParticipant : IModel
    {
        string Id { get; }

        string Name { get; }
    }
}
