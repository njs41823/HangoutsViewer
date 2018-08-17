using System.Windows.Forms;
using HangoutsViewer.ViewModels.Interfaces;

namespace HangoutsViewer.Views
{
    public partial class HangoutEventView : Form
    {
        public HangoutEventView(IHangoutEventViewModel hangoutEventViewModel)
        {
            InitializeComponent();
            HangoutEventViewModel = hangoutEventViewModel;
        }

        private IHangoutEventViewModel _hangoutEventViewModel;
        public IHangoutEventViewModel HangoutEventViewModel
        {
            get => _hangoutEventViewModel;
            set
            {
                _hangoutEventViewModel = value;
                if (_hangoutEventViewModel != null) { Bind(); }
            }
        }

        private void Bind()
        {
            BindingSource hangoutEventViewModelBinding = new BindingSource {DataSource = HangoutEventViewModel};

            TimeStampLabel.DataBindings.Clear();
            TimeStampLabel.DataBindings.Add(new Binding(nameof(TimeStampLabel.Text), hangoutEventViewModelBinding, nameof(HangoutEventViewModel.TimeStamp)));

            SenderIdLabel.DataBindings.Clear();
            SenderIdLabel.DataBindings.Add(new Binding(nameof(SenderIdLabel.Text), hangoutEventViewModelBinding, nameof(HangoutEventViewModel.SenderId)));

            SenderNameLabel.DataBindings.Clear();
            SenderNameLabel.DataBindings.Add(new Binding(nameof(SenderNameLabel.Text), hangoutEventViewModelBinding, nameof(HangoutEventViewModel.SenderName)));

            TextRichTextBox.DataBindings.Clear();
            TextRichTextBox.DataBindings.Add(new Binding(nameof(TextRichTextBox.Rtf), hangoutEventViewModelBinding, nameof(HangoutEventViewModel.TextRtf)));
            TextRichTextBox.LinkClicked -= HangoutEventViewModel.RichTextBoxLinkClicked;
            TextRichTextBox.LinkClicked += HangoutEventViewModel.RichTextBoxLinkClicked;

            AttachmentRichTextBox.DataBindings.Clear();
            AttachmentRichTextBox.DataBindings.Add(new Binding(nameof(AttachmentRichTextBox.Rtf), hangoutEventViewModelBinding, nameof(HangoutEventViewModel.AttachmentRtf)));
            AttachmentRichTextBox.LinkClicked -= HangoutEventViewModel.RichTextBoxLinkClicked;
            AttachmentRichTextBox.LinkClicked += HangoutEventViewModel.RichTextBoxLinkClicked;
        }
    }
}
