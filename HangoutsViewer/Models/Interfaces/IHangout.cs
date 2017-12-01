using System.Collections.Generic;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Interfaces
{
    public interface IHangout
    {
        string Type { get; }

        string Name { get; }

        IList<IHangoutEvent> HangoutEvents { get; }

        IList<IParticipant> Participants { get; }

        IList<IAddUserEvent> AddUserEvents { get; }

        IList<IOnTheRecordModificationEvent> OnTheRecordModiciationEvents { get; }

        IList<IRegularChatMessageEvent> RegularChatMessageEvents { get; }

        IList<IRemoveUserEvent> RemoveUserEvents { get; }

        IList<IRenameConversationEvent> RenameConversationEvents { get; }

        IList<ISmsEvent> SmsEvents { get; }

        IList<IVideoChatEvent> VideoChatEvents { get; }

        IList<IVoicemailEvent> VoicemailEvents { get; }
    }
}
