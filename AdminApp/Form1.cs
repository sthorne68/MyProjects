using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///  This app was created to centralize several VB Scripts used to perform various OS Admin related tasks.
///  Shawn Thorne
///  4.20.2017
/// </summary>
namespace AdminApp 
{    
    public partial class formAdminApp : Form
    {
        string VBFile = "";
        
        public formAdminApp()
        {
            InitializeComponent();
        }
        
                
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void resetOSAdminRadio()
        {
            foreach (RadioButton rdobtn in grpOS.Controls.OfType<RadioButton>())
            {
                    rdobtn.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetOSAdminRadio();
            btnExecute.Enabled = false;
        }


        private void rdoAddAdmin_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "AddAdmin.vbs";
        }

        private void rdoGetSW_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "GetSoftware.vbs";
            //VBFile = "GetSoftware_HTML.vbs";
        }

        private void rdoGetDBMS_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "GetDBMS.vbs";            
        }

        private void rdoGetWinVer_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "WinVer.vbs";           
        }

        private void rdoRemoteConn_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "RemoteConnection.vbs";
        }

        private void rdoReboot_CheckedChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
            VBFile = "RebootWin.vbs";
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            /// http://stackoverflow.com/questions/200422/how-to-call-a-vbscript-file-in-a-c-sharp-application    
            //Process.Start(string.Format((@"cscript //B //Nologo C:\Users\shaw3369\Documents\Visual Studio 2015\Projects\PizzaOrderForm\AdminApp\VBScripts\{0}"), VBFile)); 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
         //   string wk = process.StartInfo.WorkingDirectory = "C:\\Users\\shaw3369\\Documents\\Visual Studio 2015\\Projects\\PizzaOrderForm\\AdminApp\\VBScripts\\";
            process.StartInfo.FileName = @"Scripts\" + VBFile;
            //process.StartInfo.Arguments = txtMachineName.Text;
            process.Start();

            btnClear_Click(sender, e);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }


        private void formAdminApp_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
            btnExecute.Enabled = false;
        }
    }
}
