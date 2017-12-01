using HangoutsViewer.Models.Interfaces;

namespace HangoutsViewer.Models.Classes
{
    public class Participant : IParticipant
    {
        public string Id { get; }

        public string Name { get; }

        public Participant(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
