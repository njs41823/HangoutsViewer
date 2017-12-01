using System.Windows.Forms;
using HangoutsViewer.Models.Interfaces.HangoutEvents;

namespace HangoutsViewer.ViewModels.Interfaces
{
    public interface IHangoutEventViewModel
    {
        IHangoutEvent HangoutEvent { get; }

        string TimeStamp { get; }

        string SenderId { get; }

        string SenderName { get; }

        string Text { get; }

        string Attachment { get; }

        string TextRtf { get; }

        string AttachmentRtf { get; }

        void RichTextBoxLinkClicked(object sender, LinkClickedEventArgs e);
    }
}
