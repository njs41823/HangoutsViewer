namespace HangoutsViewer.Views
{
    partial class AboutView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
            this.AboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AboutRichTextBox
            // 
            this.AboutRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AboutRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AboutRichTextBox.Location = new System.Drawing.Point(15, 15);
            this.AboutRichTextBox.Name = "AboutRichTextBox";
            this.AboutRichTextBox.ReadOnly = true;
            this.AboutRichTextBox.Size = new System.Drawing.Size(493, 221);
            this.AboutRichTextBox.TabIndex = 2;
            this.AboutRichTextBox.Text = "";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.AboutRichTextBox);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox AboutRichTextBox;
    }
}