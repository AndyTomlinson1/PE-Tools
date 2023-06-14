using DevExpress.Data.Svg;
using PE_Tools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_Tools.Views
{
    public partial class LogView : UserControl
    {
        public delegate void FolderSelectedNotification();
        public List<string> FileNames { get; set; }
        public Folder SelectedFile{ get; set; }
        public FolderSelectedNotification Callback { get; set; }
        public List<string> LogData { get; set; }
        private Dictionary<int, string> SearchResults = new Dictionary<int, string>();
        private int selectedSearchItem = 0;

        private bool caseSensitive = false;

        public LogView()
        {
            InitializeComponent();
            this.LogData = new List<string>();
            this.outputListBox.DataSource = this.LogData;
            var files = getFiles();
            this.cbFiles.DataSource = files;
            this.cbFiles.ValueMember = "ID";
            this.cbFiles.DisplayMember = "FullPath";
            this.cbFiles.SelectedIndex = 0;
        }


        private List<Folder> getFiles()
        {
            var folderName = ConfigurationSettings.AppSettings["logFolder"];
            if (!string.IsNullOrEmpty(folderName))
            {
                FileNames = new List<string> { $"{folderName}\\CMSService.log", $"{folderName}\\Client.log" };

                if (FileNames != null && FileNames.Any())
                {
                    var files = new List<Folder>()
                    {
                        new Folder(@"select")
                    };
                    FileNames.ForEach(f => files.Add(new Folder(f)));
                    return files;
                }
            }

            return new List<Folder>() {
                new Folder(@"no folders identified in config file") 
            };
        }

        private void cbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiles.SelectedIndex < 1)
            {
                this.SelectedFile = null;
                return;
            }
            this.outputListBox.DataSource = null;
            this.SelectedFile = this.cbFiles.SelectedItem as Folder;
            using (var fs = File.Open(this.SelectedFile.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string line;

                this.LogData.Clear();

                while ((line = sr.ReadLine()) != null)
                {
                    this.LogData.Add(line);
                }
            }

            this.outputListBox.DataSource = this.LogData;

            if (this.Callback != null)
            {
                Callback();
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var searchTerm = textEdit1.Text;
            if (!string.IsNullOrWhiteSpace(searchTerm) && searchTerm.Count() >= 3)
            {
                search(searchTerm);
            }
            else
            {
                this.SearchResults.Clear();
                showSelectedItem();
            }
        }

        private void search(string searchTerm)
        {
            this.SearchResults.Clear();
            var entries = this.LogData.Where(d => caseSensitive ? d.Contains(searchTerm) : d.ToLower().Contains(searchTerm.ToLower())).ToList();
            entries.ForEach(e =>
            {
                this.SearchResults[LogData.IndexOf(e)] = e;
            });

            if(entries.Any())
            {
                this.selectedSearchItem = 0;
                showSelectedItem();
            }
            else
            {
                this.selectedSearchItem = 0;
                showSelectedItem();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(selectedSearchItem > 0)
            {
                selectedSearchItem--;
                showSelectedItem();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(selectedSearchItem < SearchResults.Count() - 1)
            {
                selectedSearchItem++;
                showSelectedItem();
            }
        }

        private void showSelectedItem()
        {
            if (SearchResults.Any())
            {
                var index = SearchResults.Keys.ToList()[selectedSearchItem];
                var nthValue = SearchResults[index];
                this.outputListBox.SelectedIndex = index;
                this.outputListBox.TopIndex = outputListBox.SelectedIndex;
                this.labelSearchSummary.Text = $"Showing result {selectedSearchItem + 1} of {SearchResults.Count}";
                this.buttonPrevious.Enabled = selectedSearchItem > 0;
                this.buttonNext.Enabled = selectedSearchItem < SearchResults.Count() - 1;
                this.buttonFirst.Enabled = this.buttonLast.Enabled = SearchResults.Any();
            }
            else
            {
                this.outputListBox.SelectedIndex = 0;
                this.outputListBox.TopIndex = outputListBox.SelectedIndex;
                this.labelSearchSummary.Text = "add search term";
                this.buttonPrevious.Enabled =
                this.buttonNext.Enabled =
                this.buttonFirst.Enabled = 
                this.buttonLast.Enabled = false; ;

            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            selectedSearchItem = SearchResults.Count() - 1;
            showSelectedItem();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            selectedSearchItem = 0;
            showSelectedItem();
        }

        private void checkBoxCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            caseSensitive = !caseSensitive;
        }
    }
}
