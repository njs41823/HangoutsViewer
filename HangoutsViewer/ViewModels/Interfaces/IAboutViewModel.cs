using System.Windows.Forms;
using HangoutsViewer.Models.Interfaces;

namespace HangoutsViewer.ViewModels.Interfaces
{
    public interface IAboutViewModel : IViewModel
    {
        IAbout About { get; }

        void AboutRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e);
    }
}
