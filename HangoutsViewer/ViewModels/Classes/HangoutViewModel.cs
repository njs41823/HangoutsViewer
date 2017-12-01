using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HangoutsViewer.ComponentModel;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Models.Interfaces.HangoutEvents;
using HangoutsViewer.ViewModels.Interfaces;

namespace HangoutsViewer.ViewModels.Classes
{
    public class HangoutViewModel : IHangoutViewModel, IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public HangoutViewModel(IHangout hangout)
        {
            Hangout = hangout;
        }

        private IHangout _hangout;
        public IHangout Hangout
        {
            get => _hangout;
            set
            {
                _hangout = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hangout)));

                HangoutEventViewModels = _hangout == null ? new SortableBindingList<IHangoutEventViewModel>(new List<IHangoutEventViewModel>()) : new SortableBindingList<IHangoutEventViewModel>((from IHangoutEvent e in _hangout.HangoutEvents select new HangoutEventViewModel(e) as IHangoutEventViewModel).ToList());
            }
        }

        private SortableBindingList<IHangoutEventViewModel> _hangoutEventViewModels;
        public SortableBindingList<IHangoutEventViewModel> HangoutEventViewModels
        {
            get => _hangoutEventViewModels;
            set
            {
                _hangoutEventViewModels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HangoutEventViewModels)));
            }
        }

        public string MessageCountString => Hangout?.HangoutEvents?.Count.ToString("N0");

        public string ParticipantsString
        {
            get
            {
                const string delimiter = ", ";
                return Hangout?.Participants == null ? string.Empty : string.Join(delimiter, from IParticipant p in Hangout.Participants select p.Name);
            }
        }
    }
}
