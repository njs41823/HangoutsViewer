using System.Linq;
using System.Windows.Forms;

namespace HangoutsViewer.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumnsToFit(
            this DataGridView dataGrid,
            ExpandColumnsToFitMode expandColumnsToFitMode = ExpandColumnsToFitMode.AllCells,
            DataGridViewColumn fillColumn = null,
            int padding = 0)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn c in dataGrid.Columns)
            {
                c.AutoSizeMode = (DataGridViewAutoSizeColumnMode)expandColumnsToFitMode;
                c.Width = c.Width + padding;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            if (fillColumn == null || !dataGrid.Columns.Contains(fillColumn)) return;
            int width = (from DataGridViewColumn c in dataGrid.Columns where c.Visible select c.Width).Sum();
            if (width >= dataGrid.Width) return;
            fillColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fillColumn.Width = fillColumn.Width;
            fillColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }
    }

    public enum ExpandColumnsToFitMode
    {
        AllCells = DataGridViewAutoSizeColumnMode.AllCells,
        AllCellsExceptHeader = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader,
        ColumnHeader = DataGridViewAutoSizeColumnMode.ColumnHeader,
        DisplayedCells = DataGridViewAutoSizeColumnMode.DisplayedCells,
        DisplayedCellsExceptHeader = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
    }
}
