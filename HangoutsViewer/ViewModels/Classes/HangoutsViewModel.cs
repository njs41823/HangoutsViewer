using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HangoutsViewer.Classes;
using HangoutsViewer.ComponentModel;
using HangoutsViewer.DataAccess;
using HangoutsViewer.Models.Classes;
using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.ViewModels.Interfaces;
using HangoutsViewer.Views;

namespace HangoutsViewer.ViewModels.Classes
{
    public class HangoutsViewModel : IHangoutsViewModel
    {
        #region Constructor

        public HangoutsViewModel(IHangouts hangouts)
        {
            if (hangouts == null) { hangouts = new Hangouts(); }
            Hangouts = hangouts;
        }

        #endregion


        #region IHangoutsViewModel Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private IHangouts _hangouts;
        public IHangouts Hangouts
        {
            get => _hangouts;
            set
            {
                _hangouts = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hangouts)));
                HangoutsDataGridSource = new SortableBindingList<IHangout>(_hangouts);
            }
        }

        public IHangoutViewModel SelectedHangoutViewModel { get; private set; }

        private SortableBindingList<IHangout> _hangoutsDataGridSource;
        public SortableBindingList<IHangout> HangoutsDataGridSource
        {
            get => _hangoutsDataGridSource;
            set
            {
                _hangoutsDataGridSource = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HangoutsDataGridSource)));

                IHangout selectedHangout = _hangouts.Any() ? _hangouts[0] : null;
                if (SelectedHangoutViewModel == null)
                {
                    SelectedHangoutViewModel = new HangoutViewModel(selectedHangout);
                }
                else
                {
                    SelectedHangoutViewModel.Hangout = selectedHangout;
                }
            }
        }


        public void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem exitToolStripMenuItem)) { return; }
            if (!(exitToolStripMenuItem.GetCurrentParent() is ToolStripDropDownMenu)) { return; }
            ToolStripMenuItem fileToolStripMenuItem = exitToolStripMenuItem.OwnerItem as ToolStripMenuItem;
            MenuStrip fileMenuStrip = fileToolStripMenuItem?.GetCurrentParent() as MenuStrip;
            Form hangoutsView = fileMenuStrip?.FindForm();
            hangoutsView?.Close();
        }

        public void GoogleTakeoutsToolStripMenuItemClick(object sender, EventArgs e)
        {
            const string googleTakeouts = "https://takeout.google.com/settings/takeout/custom/chat";
            try
            {
                Process.Start(googleTakeouts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while navigating to " + googleTakeouts + ":" + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        public void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (AboutView aboutView = new AboutView(new AboutViewModel(new About())))
            {
                aboutView.ShowDialog();
            }
        }
        
        public void HangoutsDataGridRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView hangoutsDataGrid)) { return; }
            if (e.RowIndex < 0 || e.RowIndex > hangoutsDataGrid.Rows.Count) { return; }
            if (!(hangoutsDataGrid.Rows[e.RowIndex].DataBoundItem is IHangout selectedHangout)) { return; }
            SelectedHangoutViewModel.Hangout = selectedHangout;
        }

        public void SelectedHangoutEventsDataGridDataSourceChanged(object sender, EventArgs e)
        {
            if (!(sender is DataGridView selectedHangoutEventsDataGrid)) { return; }
            DataGridViewColumn eventTextColumn = selectedHangoutEventsDataGrid.Columns["EventText"];
            if (eventTextColumn == null) { return; }
            selectedHangoutEventsDataGrid.ExpandColumnsToFit(ExpandColumnsToFitMode.DisplayedCells, eventTextColumn, 10);
        }

        public void SelectedHangoutEventsDataGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView selectedHangoutEventsDataGrid)) { return; }
            if (e.RowIndex < 0 || e.RowIndex >= selectedHangoutEventsDataGrid.Rows.Count) { return; }
            if (!(selectedHangoutEventsDataGrid.Rows[e.RowIndex].DataBoundItem is IHangoutEventViewModel clickedEventViewModel)) { return; }
            using (HangoutEventView hangoutEventView = new HangoutEventView(clickedEventViewModel))
            {
                hangoutEventView.ShowDialog();
            }
        }

        public void SelectedHangoutEventsDataGridCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(sender is DataGridView selectedHangoutEventsDataGrid)) { return; }
            if (e.RowIndex < 0 || e.RowIndex >= selectedHangoutEventsDataGrid.RowCount) { return; }
            if (!(selectedHangoutEventsDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell clickedLinkCell)) { return; }

            if (!Uri.IsWellFormedUriString(clickedLinkCell.Value.ToString(), UriKind.Absolute))
            {
                MessageBox.Show("Invalid link", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Process.Start(clickedLinkCell.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while navigating to " + clickedLinkCell.Value + ":" + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine + 
                    "Message: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        public async void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Hangouts .json file";
                openFileDialog.AddExtension = true;
                openFileDialog.CheckFileExists = true;
                openFileDialog.DefaultExt = ".json";
                openFileDialog.Filter = "Json files (*.json)|*.json";
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = false;
                openFileDialog.ValidateNames = true;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Directory.Exists(@"C:\Users\Dell\Desktop\Hangout Text Files")) { openFileDialog.InitialDirectory = @"C:\Users\Dell\Desktop\Hangout Text Files"; }
                if (openFileDialog.ShowDialog() != DialogResult.OK) { return; }
                fileName = openFileDialog.FileName;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show("File " + fileName + " not found!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form selectButtonForm = ((ToolStripMenuItem)((ToolStripDropDownMenu)((ToolStripMenuItem)sender).GetCurrentParent()).OwnerItem).GetCurrentParent().FindForm();
            if (selectButtonForm != null)
            {
                selectButtonForm.Cursor = Cursors.WaitCursor;
                foreach (Control c in selectButtonForm.Controls)
                {
                    c.Enabled = false;
                }
            }

            Hangouts = new Hangouts();
            try
            {
                Hangouts = await HangoutsJsonParser.ParseAsync(new FileInfo(fileName));
            }
            catch (FileNotFoundException fileEx)
            {
                MessageBox.Show(fileEx.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException dirEx)
            {
                MessageBox.Show(dirEx.Message, "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is NullReferenceException)
                {
                    MessageBox.Show("File format not recognized", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(
                    "An error occurred:" + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (selectButtonForm != null)
                {
                    selectButtonForm.Cursor = Cursors.Default;
                    foreach (Control c in selectButtonForm.Controls)
                    {
                        c.Enabled = true;
                    }
                }
            }
        }

        public async void ExportButtonClick(object sender, EventArgs e)
        {
            string fileName;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.ValidateNames = true;
                saveFileDialog.AddExtension = true;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = ".csv";
                saveFileDialog.Filter = "Csv files (*.csv)|*.csv";
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.Title = "Select a Hangouts .json file";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
                fileName = saveFileDialog.FileName;
            }

            Form hangoutsView = ((Button)sender).FindForm();
            if (hangoutsView != null)
            {
                hangoutsView.Cursor = Cursors.WaitCursor;
                foreach (Control c in hangoutsView.Controls)
                {
                    c.Enabled = false;
                }
            }
            try
            {
                await HangoutCsvExporter.ExportHangout(SelectedHangoutViewModel.Hangout, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occcurred while exporting " + SelectedHangoutViewModel.Hangout.Name + " to csv:" + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (hangoutsView != null)
                {
                    hangoutsView.Cursor = Cursors.Default;
                    foreach (Control c in hangoutsView.Controls)
                    {
                        c.Enabled = true;
                    }
                }
            }

            if (MessageBox.Show("Do you want to open " + fileName + "?", "Open .csv?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) { return; }
            try
            {
                Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occcurred while attempting to open " + fileName + ":" + Environment.NewLine + Environment.NewLine +
                    "Type: " + ex.GetType().Name + Environment.NewLine +
                    "Message: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
        }

        public void HangoutsViewFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                //return;
            }
        }

        #endregion
    }
}
