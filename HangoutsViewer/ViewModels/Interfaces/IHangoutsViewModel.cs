using System;
using System.Windows.Forms;
using HangoutsViewer.ComponentModel;
using HangoutsViewer.Models.Interfaces;

namespace HangoutsViewer.ViewModels.Interfaces
{
    public interface IHangoutsViewModel : IViewModel
    {
        IHangouts Hangouts { get; set; }

        IHangoutViewModel SelectedHangoutViewModel { get; }

        SortableBindingList<IHangout> HangoutsDataGridSource { get; set; }

        void ExportButtonClick(object sender, EventArgs e);

        void OpenToolStripMenuItemClick(object sender, EventArgs e);

        void ExitToolStripMenuItemClick(object sender, EventArgs e);

        void GoogleTakeoutsToolStripMenuItemClick(object sender, EventArgs e);

        void AboutToolStripMenuItemClick(object sender, EventArgs e);

        void HangoutsDataGridRowEnter(object sender, DataGridViewCellEventArgs e);

        void SelectedHangoutEventsDataGridDataSourceChanged(object sender, EventArgs e);

        void SelectedHangoutEventsDataGridCellDoubleClick(object sender, DataGridViewCellEventArgs e);

        void SelectedHangoutEventsDataGridCellContentClick(object sender, DataGridViewCellEventArgs e);

        void SelectedHangoutEventsDataGrid_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e);

        void HangoutsViewFormClosing(object sender, FormClosingEventArgs e);
    }
}
