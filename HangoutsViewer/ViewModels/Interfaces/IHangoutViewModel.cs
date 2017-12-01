using HangoutsViewer.ComponentModel;
using HangoutsViewer.Models.Interfaces;

namespace HangoutsViewer.ViewModels.Interfaces
{
    public interface IHangoutViewModel
    {
        IHangout Hangout { get; set; }

        SortableBindingList<IHangoutEventViewModel> HangoutEventViewModels { get; }

        string MessageCountString { get; }

        string ParticipantsString { get; }
    }
}
