using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.ViewModels.Interfaces;

namespace HangoutsViewer.ViewModels.Classes
{
    public class AboutViewModel : IAboutViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public AboutViewModel(IAbout about)
        {
            About = about;
        }

        private IAbout _about;
        public IAbout About
        {
            get => _about;
            set
            {
                _about = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(About)));
            }
        }

        public void AboutRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while attempting to browse to {e.LinkText}{Environment.NewLine}{Environment.NewLine}" +
                    $"Error Type: {ex.GetType().Name}{Environment.NewLine}" +
                    $"Error Message: {ex.Message}{Environment.NewLine}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }
    }
}
