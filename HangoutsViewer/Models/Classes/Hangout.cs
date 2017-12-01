using System.Collections.Generic;
using System.Linq;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.Models.Classes
{
    public class Hangout : IHangout
    {
        #region Constructor

        public Hangout(string type, string name, IList<IHangoutEvent> hangoutEvents, IList<IParticipant> participants)
        {
            Type = type;
            Name = name;
            HangoutEvents = hangoutEvents;
            Participants = participants;
        }

        #endregion


        #region IHangout Implementation

        #region Properties

        public string Type { get; }

        public string Name { get; }
        
        public IList<IHangoutEvent> HangoutEvents { get; }
        
        public IList<IParticipant> Participants { get; }

        #endregion

        #region Derived Properties

        public IList<IAddUserEvent> AddUserEvents => GetEvents<IAddUserEvent>();

        public IList<IOnTheRecordModificationEvent> OnTheRecordModiciationEvents => GetEvents<IOnTheRecordModificationEvent>();

        public IList<IRegularChatMessageEvent> RegularChatMessageEvents => GetEvents<IRegularChatMessageEvent>();

        public IList<IRemoveUserEvent> RemoveUserEvents => GetEvents<IRemoveUserEvent>();

        public IList<IRenameConversationEvent> RenameConversationEvents => GetEvents<IRenameConversationEvent>();

        public IList<ISmsEvent> SmsEvents => GetEvents<ISmsEvent>();

        public IList<IVideoChatEvent> VideoChatEvents => GetEvents<IVideoChatEvent>();

        public IList<IVoicemailEvent> VoicemailEvents => GetEvents<IVoicemailEvent>();

        #endregion

        #endregion


        #region Helper Methods

        private IList<T> GetEvents<T>()
        {
            return
                (from IHangoutEvent hangoutEvent in HangoutEvents where hangoutEvent is T select (T)hangoutEvent).ToList();
        }

        #endregion
    }
}
