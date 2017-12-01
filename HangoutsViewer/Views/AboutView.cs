using System.Windows.Forms;
using HangoutsViewer.ViewModels.Interfaces;

namespace HangoutsViewer.Views
{
    public partial class AboutView : Form
    {
        private IAboutViewModel _aboutViewModel;
        public IAboutViewModel AboutViewModel
        {
            get => _aboutViewModel;
            set
            {
                _aboutViewModel = value;
                if (_aboutViewModel != null) { Bind(); }
            }
        }

        public AboutView(IAboutViewModel aboutViewModel)
        {
            InitializeComponent();
            AboutViewModel = aboutViewModel;
        }

        private void Bind()
        {
            AboutRichTextBox.DataBindings.Add("Rtf", AboutViewModel.About, "AboutText");
            AboutRichTextBox.LinkClicked += AboutViewModel.AboutRichTextBox_LinkClicked;
        }
    }
}
