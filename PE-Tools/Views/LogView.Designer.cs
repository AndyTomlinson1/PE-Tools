namespace PE_Tools.Views
{
    partial class LogView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlProjectSelector1 = new PE_Tools.Views.UserControlProjectSelector();
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.labelSelectLog = new DevExpress.XtraEditors.LabelControl();
            this.cbFolders = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userControlProjectSelector1
            // 
            this.userControlProjectSelector1.Callback = null;
            this.userControlProjectSelector1.FolderNames = null;
            this.userControlProjectSelector1.Location = new System.Drawing.Point(14, 37);
            this.userControlProjectSelector1.Name = "userControlProjectSelector1";
            this.userControlProjectSelector1.SelectedFolder = null;
            this.userControlProjectSelector1.Size = new System.Drawing.Size(395, 71);
            this.userControlProjectSelector1.TabIndex = 44;
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Appearance.Options.UseFont = true;
            this.titleLabelControl.Location = new System.Drawing.Point(14, 12);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(124, 22);
            this.titleLabelControl.TabIndex = 43;
            this.titleLabelControl.Text = "View PE Logs";
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.outputListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(23, 113);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(1113, 276);
            this.outputListBox.TabIndex = 45;
            // 
            // labelSelectLog
            // 
            this.labelSelectLog.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectLog.Appearance.Options.UseFont = true;
            this.labelSelectLog.Location = new System.Drawing.Point(422, 52);
            this.labelSelectLog.Name = "labelSelectLog";
            this.labelSelectLog.Size = new System.Drawing.Size(62, 16);
            this.labelSelectLog.TabIndex = 49;
            this.labelSelectLog.Text = "Select Log";
            // 
            // cbFolders
            // 
            this.cbFolders.FormattingEnabled = true;
            this.cbFolders.Location = new System.Drawing.Point(422, 74);
            this.cbFolders.Name = "cbFolders";
            this.cbFolders.Size = new System.Drawing.Size(364, 21);
            this.cbFolders.TabIndex = 50;
            this.cbFolders.SelectedIndexChanged += new System.EventHandler(this.cbFolders_SelectedIndexChanged);
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFolders);
            this.Controls.Add(this.labelSelectLog);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.userControlProjectSelector1);
            this.Controls.Add(this.titleLabelControl);
            this.Name = "LogView";
            this.Size = new System.Drawing.Size(1145, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlProjectSelector userControlProjectSelector1;
        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private System.Windows.Forms.ListBox outputListBox;
        private DevExpress.XtraEditors.LabelControl labelSelectLog;
        private System.Windows.Forms.ComboBox cbFolders;
    }
}
