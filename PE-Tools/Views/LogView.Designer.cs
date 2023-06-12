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
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.labelSelectLog = new DevExpress.XtraEditors.LabelControl();
            this.cbFiles = new System.Windows.Forms.ComboBox();
            this.labelSearch = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelSearchSummary = new DevExpress.XtraEditors.LabelControl();
            this.userControlProjectSelector1 = new PE_Tools.Views.UserControlProjectSelector();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.labelSelectLog.Location = new System.Drawing.Point(23, 50);
            this.labelSelectLog.Name = "labelSelectLog";
            this.labelSelectLog.Size = new System.Drawing.Size(62, 16);
            this.labelSelectLog.TabIndex = 49;
            this.labelSelectLog.Text = "Select Log";
            // 
            // cbFiles
            // 
            this.cbFiles.FormattingEnabled = true;
            this.cbFiles.Location = new System.Drawing.Point(111, 49);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Size = new System.Drawing.Size(364, 21);
            this.cbFiles.TabIndex = 50;
            this.cbFiles.SelectedIndexChanged += new System.EventHandler(this.cbFiles_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Appearance.Options.UseFont = true;
            this.labelSearch.Location = new System.Drawing.Point(23, 77);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(74, 16);
            this.labelSearch.TabIndex = 51;
            this.labelSearch.Text = "Search Term";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(111, 76);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(196, 20);
            this.textEdit1.TabIndex = 52;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(844, 72);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 53;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(763, 72);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 54;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelSearchSummary
            // 
            this.labelSearchSummary.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchSummary.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSearchSummary.Appearance.Options.UseFont = true;
            this.labelSearchSummary.Appearance.Options.UseForeColor = true;
            this.labelSearchSummary.Location = new System.Drawing.Point(332, 77);
            this.labelSearchSummary.Name = "labelSearchSummary";
            this.labelSearchSummary.Size = new System.Drawing.Size(94, 16);
            this.labelSearchSummary.TabIndex = 55;
            this.labelSearchSummary.Text = "add search term";
            // 
            // userControlProjectSelector1
            // 
            this.userControlProjectSelector1.Callback = null;
            this.userControlProjectSelector1.FolderNames = null;
            this.userControlProjectSelector1.Location = new System.Drawing.Point(650, 3);
            this.userControlProjectSelector1.Name = "userControlProjectSelector1";
            this.userControlProjectSelector1.SelectedFolder = null;
            this.userControlProjectSelector1.Size = new System.Drawing.Size(395, 71);
            this.userControlProjectSelector1.TabIndex = 44;
            this.userControlProjectSelector1.Visible = false;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Enabled = false;
            this.buttonFirst.Location = new System.Drawing.Point(663, 72);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 56;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            this.buttonFirst.Enabled = false;
            // 
            // buttonLast
            // 
            this.buttonLast.Enabled = false;
            this.buttonLast.Location = new System.Drawing.Point(953, 72);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 57;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            this.buttonLast.Enabled = false;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.labelSearchSummary);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.cbFiles);
            this.Controls.Add(this.labelSelectLog);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.userControlProjectSelector1);
            this.Controls.Add(this.titleLabelControl);
            this.Name = "LogView";
            this.Size = new System.Drawing.Size(1145, 393);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlProjectSelector userControlProjectSelector1;
        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private System.Windows.Forms.ListBox outputListBox;
        private DevExpress.XtraEditors.LabelControl labelSelectLog;
        private System.Windows.Forms.ComboBox cbFiles;
        private DevExpress.XtraEditors.LabelControl labelSearch;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private DevExpress.XtraEditors.LabelControl labelSearchSummary;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
    }
}
