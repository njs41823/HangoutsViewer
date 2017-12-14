namespace HangoutsViewer.Views
{
    partial class HangoutsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangoutsView));
            this.SelectedHangoutParticipantsLabel = new System.Windows.Forms.Label();
            this.SelectedHangoutParticipantsLabelLabel = new System.Windows.Forms.Label();
            this.SelectedHangoutInfoPanel = new System.Windows.Forms.Panel();
            this.SelectedHangoutMessagesCountLabel = new System.Windows.Forms.Label();
            this.SelectedHangoutMessagesCountLabelLabel = new System.Windows.Forms.Label();
            this.SelectedHangoutNameLabel = new System.Windows.Forms.Label();
            this.SelectedHangoutNameLabelLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.HangoutsDataGrid = new System.Windows.Forms.DataGridView();
            this.HangoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedHangoutEventsDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attachment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoogleTakeoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HangoutsSplitPanel = new System.Windows.Forms.SplitContainer();
            this.SelectedHangoutInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangoutsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedHangoutEventsDataGrid)).BeginInit();
            this.FileMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangoutsSplitPanel)).BeginInit();
            this.HangoutsSplitPanel.Panel1.SuspendLayout();
            this.HangoutsSplitPanel.Panel2.SuspendLayout();
            this.HangoutsSplitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedHangoutParticipantsLabel
            // 
            this.SelectedHangoutParticipantsLabel.AutoSize = true;
            this.SelectedHangoutParticipantsLabel.Location = new System.Drawing.Point(164, 34);
            this.SelectedHangoutParticipantsLabel.Name = "SelectedHangoutParticipantsLabel";
            this.SelectedHangoutParticipantsLabel.Size = new System.Drawing.Size(121, 15);
            this.SelectedHangoutParticipantsLabel.TabIndex = 5;
            this.SelectedHangoutParticipantsLabel.Text = "                                      ";
            // 
            // SelectedHangoutParticipantsLabelLabel
            // 
            this.SelectedHangoutParticipantsLabelLabel.AutoSize = true;
            this.SelectedHangoutParticipantsLabelLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedHangoutParticipantsLabelLabel.Location = new System.Drawing.Point(83, 34);
            this.SelectedHangoutParticipantsLabelLabel.Name = "SelectedHangoutParticipantsLabelLabel";
            this.SelectedHangoutParticipantsLabelLabel.Size = new System.Drawing.Size(80, 15);
            this.SelectedHangoutParticipantsLabelLabel.TabIndex = 1;
            this.SelectedHangoutParticipantsLabelLabel.Text = "Participants:";
            // 
            // SelectedHangoutInfoPanel
            // 
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutMessagesCountLabel);
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutMessagesCountLabelLabel);
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutNameLabel);
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutNameLabelLabel);
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutParticipantsLabel);
            this.SelectedHangoutInfoPanel.Controls.Add(this.ExportButton);
            this.SelectedHangoutInfoPanel.Controls.Add(this.SelectedHangoutParticipantsLabelLabel);
            this.SelectedHangoutInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedHangoutInfoPanel.Location = new System.Drawing.Point(0, 329);
            this.SelectedHangoutInfoPanel.Name = "SelectedHangoutInfoPanel";
            this.SelectedHangoutInfoPanel.Size = new System.Drawing.Size(784, 82);
            this.SelectedHangoutInfoPanel.TabIndex = 14;
            // 
            // SelectedHangoutMessagesCountLabel
            // 
            this.SelectedHangoutMessagesCountLabel.AutoSize = true;
            this.SelectedHangoutMessagesCountLabel.Location = new System.Drawing.Point(164, 56);
            this.SelectedHangoutMessagesCountLabel.Name = "SelectedHangoutMessagesCountLabel";
            this.SelectedHangoutMessagesCountLabel.Size = new System.Drawing.Size(121, 15);
            this.SelectedHangoutMessagesCountLabel.TabIndex = 9;
            this.SelectedHangoutMessagesCountLabel.Text = "                                      ";
            // 
            // SelectedHangoutMessagesCountLabelLabel
            // 
            this.SelectedHangoutMessagesCountLabelLabel.AutoSize = true;
            this.SelectedHangoutMessagesCountLabelLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedHangoutMessagesCountLabelLabel.Location = new System.Drawing.Point(92, 56);
            this.SelectedHangoutMessagesCountLabelLabel.Name = "SelectedHangoutMessagesCountLabelLabel";
            this.SelectedHangoutMessagesCountLabelLabel.Size = new System.Drawing.Size(71, 15);
            this.SelectedHangoutMessagesCountLabelLabel.TabIndex = 8;
            this.SelectedHangoutMessagesCountLabelLabel.Text = "Messages:";
            // 
            // SelectedHangoutNameLabel
            // 
            this.SelectedHangoutNameLabel.AutoSize = true;
            this.SelectedHangoutNameLabel.Location = new System.Drawing.Point(164, 12);
            this.SelectedHangoutNameLabel.Name = "SelectedHangoutNameLabel";
            this.SelectedHangoutNameLabel.Size = new System.Drawing.Size(121, 15);
            this.SelectedHangoutNameLabel.TabIndex = 7;
            this.SelectedHangoutNameLabel.Text = "                                      ";
            // 
            // SelectedHangoutNameLabelLabel
            // 
            this.SelectedHangoutNameLabelLabel.AutoSize = true;
            this.SelectedHangoutNameLabelLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedHangoutNameLabelLabel.Location = new System.Drawing.Point(67, 12);
            this.SelectedHangoutNameLabelLabel.Name = "SelectedHangoutNameLabelLabel";
            this.SelectedHangoutNameLabelLabel.Size = new System.Drawing.Size(96, 15);
            this.SelectedHangoutNameLabelLabel.TabIndex = 6;
            this.SelectedHangoutNameLabelLabel.Text = "Hangout Name:";
            this.SelectedHangoutNameLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExportButton
            // 
            this.ExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExportButton.Image = global::HangoutsViewer.Properties.Resources.csvicon;
            this.ExportButton.Location = new System.Drawing.Point(11, 11);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(50, 60);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // HangoutsDataGrid
            // 
            this.HangoutsDataGrid.AllowUserToAddRows = false;
            this.HangoutsDataGrid.AllowUserToDeleteRows = false;
            this.HangoutsDataGrid.AllowUserToResizeRows = false;
            this.HangoutsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HangoutsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.HangoutsDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.HangoutsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.HangoutsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HangoutsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HangoutsDataGrid.ColumnHeadersHeight = 26;
            this.HangoutsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.HangoutsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HangoutName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HangoutsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.HangoutsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HangoutsDataGrid.EnableHeadersVisualStyles = false;
            this.HangoutsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.HangoutsDataGrid.MultiSelect = false;
            this.HangoutsDataGrid.Name = "HangoutsDataGrid";
            this.HangoutsDataGrid.ReadOnly = true;
            this.HangoutsDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HangoutsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.HangoutsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HangoutsDataGrid.Size = new System.Drawing.Size(160, 305);
            this.HangoutsDataGrid.TabIndex = 0;
            // 
            // HangoutName
            // 
            this.HangoutName.DataPropertyName = "Name";
            this.HangoutName.HeaderText = "Hangouts";
            this.HangoutName.Name = "HangoutName";
            this.HangoutName.ReadOnly = true;
            this.HangoutName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SelectedHangoutEventsDataGrid
            // 
            this.SelectedHangoutEventsDataGrid.AllowUserToAddRows = false;
            this.SelectedHangoutEventsDataGrid.AllowUserToDeleteRows = false;
            this.SelectedHangoutEventsDataGrid.AllowUserToResizeRows = false;
            this.SelectedHangoutEventsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SelectedHangoutEventsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SelectedHangoutEventsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SelectedHangoutEventsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedHangoutEventsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SelectedHangoutEventsDataGrid.ColumnHeadersHeight = 26;
            this.SelectedHangoutEventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SelectedHangoutEventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.SenderName,
            this.EventText,
            this.Attachment});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectedHangoutEventsDataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.SelectedHangoutEventsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedHangoutEventsDataGrid.EnableHeadersVisualStyles = false;
            this.SelectedHangoutEventsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.SelectedHangoutEventsDataGrid.Name = "SelectedHangoutEventsDataGrid";
            this.SelectedHangoutEventsDataGrid.ReadOnly = true;
            this.SelectedHangoutEventsDataGrid.RowHeadersVisible = false;
            this.SelectedHangoutEventsDataGrid.Size = new System.Drawing.Size(620, 305);
            this.SelectedHangoutEventsDataGrid.TabIndex = 4;
            // 
            // TimeStamp
            // 
            this.TimeStamp.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TimeStamp.DefaultCellStyle = dataGridViewCellStyle5;
            this.TimeStamp.HeaderText = "Timestamp";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SenderName
            // 
            this.SenderName.DataPropertyName = "SenderName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.SenderName.DefaultCellStyle = dataGridViewCellStyle6;
            this.SenderName.HeaderText = "Sender";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            this.SenderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EventText
            // 
            this.EventText.DataPropertyName = "Text";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventText.DefaultCellStyle = dataGridViewCellStyle7;
            this.EventText.HeaderText = "Text";
            this.EventText.Name = "EventText";
            this.EventText.ReadOnly = true;
            this.EventText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Attachment
            // 
            this.Attachment.DataPropertyName = "Attachment";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Attachment.DefaultCellStyle = dataGridViewCellStyle8;
            this.Attachment.HeaderText = "Attachment";
            this.Attachment.Name = "Attachment";
            this.Attachment.ReadOnly = true;
            this.Attachment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.FileMenuStrip.TabIndex = 13;
            this.FileMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoogleTakeoutsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // GoogleTakeoutsToolStripMenuItem
            // 
            this.GoogleTakeoutsToolStripMenuItem.Name = "GoogleTakeoutsToolStripMenuItem";
            this.GoogleTakeoutsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.GoogleTakeoutsToolStripMenuItem.Text = "Google Takeouts";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // HangoutsSplitPanel
            // 
            this.HangoutsSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HangoutsSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.HangoutsSplitPanel.Location = new System.Drawing.Point(0, 24);
            this.HangoutsSplitPanel.Name = "HangoutsSplitPanel";
            // 
            // HangoutsSplitPanel.Panel1
            // 
            this.HangoutsSplitPanel.Panel1.Controls.Add(this.HangoutsDataGrid);
            // 
            // HangoutsSplitPanel.Panel2
            // 
            this.HangoutsSplitPanel.Panel2.Controls.Add(this.SelectedHangoutEventsDataGrid);
            this.HangoutsSplitPanel.Size = new System.Drawing.Size(784, 305);
            this.HangoutsSplitPanel.SplitterDistance = 160;
            this.HangoutsSplitPanel.TabIndex = 17;
            // 
            // HangoutsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.HangoutsSplitPanel);
            this.Controls.Add(this.SelectedHangoutInfoPanel);
            this.Controls.Add(this.FileMenuStrip);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangoutsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangouts Viewer";
            this.SelectedHangoutInfoPanel.ResumeLayout(false);
            this.SelectedHangoutInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangoutsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedHangoutEventsDataGrid)).EndInit();
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.HangoutsSplitPanel.Panel1.ResumeLayout(false);
            this.HangoutsSplitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangoutsSplitPanel)).EndInit();
            this.HangoutsSplitPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedHangoutParticipantsLabel;
        private System.Windows.Forms.Label SelectedHangoutParticipantsLabelLabel;
        private System.Windows.Forms.Panel SelectedHangoutInfoPanel;
        private System.Windows.Forms.Label SelectedHangoutMessagesCountLabel;
        private System.Windows.Forms.Label SelectedHangoutMessagesCountLabelLabel;
        private System.Windows.Forms.Label SelectedHangoutNameLabel;
        private System.Windows.Forms.Label SelectedHangoutNameLabelLabel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.DataGridView HangoutsDataGrid;
        private System.Windows.Forms.DataGridView SelectedHangoutEventsDataGrid;
        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoogleTakeoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangoutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventText;
        private System.Windows.Forms.DataGridViewLinkColumn Attachment;
        private System.Windows.Forms.SplitContainer HangoutsSplitPanel;
    }
}