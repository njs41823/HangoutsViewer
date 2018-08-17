using System;
using System.Windows.Forms;
using HangoutsViewer.Models.Interfaces.HangoutEvents;
using HangoutsViewer.ViewModels.Interfaces;
using System.Diagnostics;

namespace HangoutsViewer.ViewModels.Classes
{
    public class HangoutEventViewModel : IHangoutEventViewModel
    {
        public HangoutEventViewModel(IHangoutEvent hangoutEvent)
        {
            HangoutEvent = hangoutEvent;
        }

        public IHangoutEvent HangoutEvent { get; }

        public string TimeStamp => HangoutEvent.TimeStamp.ToString("MM/dd/yyyy hh:mm:ss tt");

        public string SenderId => HangoutEvent.Sender.Id;

        public string SenderName => HangoutEvent.Sender.Name;

        public string Text => HangoutEvent.Text;

        public string Attachment => HangoutEvent.Attachment;

        public string TextRtf => @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Roboto;}}\r\n{\*\generator Riched20 10.0.15063}\viewkind4\uc1 \r\n\pard\sa200\sl276\slmult1\f0\fs20\lang9 " + Text + @"\f1\fs22\par\r\n}\r\n ";

        public string AttachmentRtf => @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Roboto;}}\r\n{\*\generator Riched20 10.0.15063}\viewkind4\uc1 \r\n\pard\sa200\sl276\slmult1\f0\fs20\lang9 " + Attachment + @"\f1\fs22\par\r\n}\r\n ";

        public void RichTextBoxLinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (!Uri.IsWellFormedUriString(e.LinkText, UriKind.Absolute)) { return; }
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while attempting to browse to {e.LinkText}{Environment.NewLine}{Environment.NewLine}" +
                    $"Error Type: {ex.GetType().Name}{Environment.NewLine}" +
                    $"Error Message: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
