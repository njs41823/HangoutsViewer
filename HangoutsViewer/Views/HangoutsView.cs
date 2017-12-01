using System.Windows.Forms;
using HangoutsViewer.ViewModels.Interfaces;
using HangoutsViewer.Models.Interfaces;

namespace HangoutsViewer.Views
{
    public partial class HangoutsView : Form
    {
        public HangoutsView(IHangoutsViewModel hangoutsViewModel)
        {
            InitializeComponent();
            HangoutsViewModel = hangoutsViewModel;
        }

        private IHangoutsViewModel _hangoutsViewModel;
        public IHangoutsViewModel HangoutsViewModel
        {
            get => _hangoutsViewModel;
            set
            {
                _hangoutsViewModel = value;
                if (_hangoutsViewModel != null) { Bind(); }
            }
        }

        private void Bind()
        {
            BindingSource hangoutsViewModelBinding = new BindingSource {DataSource = HangoutsViewModel};
            BindingSource selectedHangoutViewModelBinding = new BindingSource {DataSource = HangoutsViewModel.SelectedHangoutViewModel};
            
            HangoutsDataGrid.AutoGenerateColumns = false;
            HangoutsDataGrid.DataBindings.Clear();
            HangoutsDataGrid.DataBindings.Add(new Binding("DataSource", hangoutsViewModelBinding, "HangoutsDataGridSource"));

            SelectedHangoutEventsDataGrid.AutoGenerateColumns = false;
            SelectedHangoutEventsDataGrid.DataBindings.Clear();
            SelectedHangoutEventsDataGrid.DataBindings.Add(new Binding("DataSource", selectedHangoutViewModelBinding, "HangoutEventViewModels"));

            SelectedHangoutNameLabel.DataBindings.Clear();
            SelectedHangoutNameLabel.DataBindings.Add(new Binding("Text", selectedHangoutViewModelBinding, "Hangout.Name"));

            SelectedHangoutParticipantsLabel.DataBindings.Clear();
            SelectedHangoutParticipantsLabel.DataBindings.Add(new Binding("Text", selectedHangoutViewModelBinding, "ParticipantsString"));

            SelectedHangoutMessagesCountLabel.DataBindings.Clear();
            SelectedHangoutMessagesCountLabel.DataBindings.Add(new Binding("Text", selectedHangoutViewModelBinding, "MessageCountString"));

            Binding exportButtonBinding = new Binding("Enabled", selectedHangoutViewModelBinding, "Hangout");
            exportButtonBinding.Format += (sender, e) => { e.Value = (IHangout)e.Value != null; };
            ExportButton.DataBindings.Add(exportButtonBinding);

            ExportButton.Click -= HangoutsViewModel.ExportButtonClick;
            ExportButton.Click += HangoutsViewModel.ExportButtonClick;

            SelectedHangoutEventsDataGrid.DataSourceChanged -= HangoutsViewModel.SelectedHangoutEventsDataGridDataSourceChanged;
            SelectedHangoutEventsDataGrid.DataSourceChanged += HangoutsViewModel.SelectedHangoutEventsDataGridDataSourceChanged;

            SelectedHangoutEventsDataGrid.CellDoubleClick -= HangoutsViewModel.SelectedHangoutEventsDataGridCellDoubleClick;
            SelectedHangoutEventsDataGrid.CellDoubleClick += HangoutsViewModel.SelectedHangoutEventsDataGridCellDoubleClick;

            SelectedHangoutEventsDataGrid.CellContentClick -= HangoutsViewModel.SelectedHangoutEventsDataGridCellContentClick;
            SelectedHangoutEventsDataGrid.CellContentClick += HangoutsViewModel.SelectedHangoutEventsDataGridCellContentClick;

            HangoutsDataGrid.RowEnter -= HangoutsViewModel.HangoutsDataGridRowEnter;
            HangoutsDataGrid.RowEnter += HangoutsViewModel.HangoutsDataGridRowEnter;

            OpenToolStripMenuItem.Click -= HangoutsViewModel.OpenToolStripMenuItemClick;
            OpenToolStripMenuItem.Click += HangoutsViewModel.OpenToolStripMenuItemClick;

            ExitToolStripMenuItem.Click -= HangoutsViewModel.ExitToolStripMenuItemClick;
            ExitToolStripMenuItem.Click += HangoutsViewModel.ExitToolStripMenuItemClick;

            GoogleTakeoutsToolStripMenuItem.Click -= HangoutsViewModel.GoogleTakeoutsToolStripMenuItemClick;
            GoogleTakeoutsToolStripMenuItem.Click += HangoutsViewModel.GoogleTakeoutsToolStripMenuItemClick;

            AboutToolStripMenuItem.Click -= HangoutsViewModel.AboutToolStripMenuItemClick;
            AboutToolStripMenuItem.Click += HangoutsViewModel.AboutToolStripMenuItemClick;

            FormClosing -= HangoutsViewModel.HangoutsViewFormClosing;
            FormClosing += HangoutsViewModel.HangoutsViewFormClosing;
        }
    }
}
