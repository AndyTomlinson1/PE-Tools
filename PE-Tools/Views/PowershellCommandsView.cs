﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//In Package Manager Console change dir to get to project folder then add the following package for WinForms
//cd  PE-Tools
//dotnet add package Microsoft.PowerShell.5.ReferenceAssemblies --version 1.1.0

//For non-historic apps just install System.Management.Automation using Nuget

//these both give you System.Management.Automation.Runspaces

namespace PE_Tools.Views
{
    public partial class PowershellCommandsView : UserControl
    {
        public PowershellCommandsView()
        {
            InitializeComponent();
        }

        private void PowershellCommandsView_Load(object sender, EventArgs e)
        {
            checkElevatedMode();
        }

        private string RunScript(string script, bool requiresAuth = false, string changeDir = null)
        {
            var sb = new StringBuilder();
            try
            {
                var runspace = RunspaceFactory.CreateRunspace();
                runspace.Open();
                var pipeline = runspace.CreatePipeline();
                if (requiresAuth)
                {
                    pipeline.Commands.AddScript("Set-ExecutionPolicy Unrestricted");
                }
                if(!string.IsNullOrEmpty(changeDir))
                {
                    pipeline.Commands.AddScript($"cd {changeDir}");
                }
                pipeline.Commands.AddScript(script);
                pipeline.Commands.Add("Out-String");
                var results = pipeline.Invoke();
                runspace.Close();

                foreach (var obj in results)
                {
                    sb.AppendLine(obj.ToString());
                }
            }
            catch(Exception e)
            {
                sb.AppendLine(e.Message);
                return sb.ToString();
            }
            return sb.ToString();
        }

        private void ShowMessage(string msg)
        {
            tbResults.Clear();
            tbResults.Text = RunScript(msg);
        }

        private void checkElevatedMode()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if(!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                ShowMessage("echo \'You need to run this application as administrator to use most powershell tools\'");
            }
        }

        private void tbCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                tbResults.Clear();
                tbResults.Text = RunScript(tbCommand.Text);
            }
        }
        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            tbResults.Text = RunScript("./RunPE.ps1", true);
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            tbResults.Text = RunScript("./start.ps1 -build", true,@"c:\dev\onprem\");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            tbResults.Text = RunScript("./StopPE.ps1", true);
        }
    }
}
