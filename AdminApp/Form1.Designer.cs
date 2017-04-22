namespace AdminApp
{
    partial class formAdminApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Naperville",
            "Open"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "RedTrolley",
            "Started"}, -1);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.grpOS = new System.Windows.Forms.GroupBox();
            this.rdoReboot = new System.Windows.Forms.RadioButton();
            this.rdoRemoteConn = new System.Windows.Forms.RadioButton();
            this.rdoGetWinVer = new System.Windows.Forms.RadioButton();
            this.rdoGetDBMS = new System.Windows.Forms.RadioButton();
            this.rdoGetSW = new System.Windows.Forms.RadioButton();
            this.rdoAddAdmin = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEZCONNECT = new System.Windows.Forms.TextBox();
            this.txtSysPassword = new System.Windows.Forms.TextBox();
            this.lblSysPswd = new System.Windows.Forms.Label();
            this.lblEZConnect = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rdoESRIServices = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpOS.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(502, 407);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.grpOS);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(314, 170);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(140, 39);
            this.btnExecute.TabIndex = 15;
            this.btnExecute.Text = "EXECUTE";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // grpOS
            // 
            this.grpOS.Controls.Add(this.rdoESRIServices);
            this.grpOS.Controls.Add(this.rdoReboot);
            this.grpOS.Controls.Add(this.rdoGetSW);
            this.grpOS.Controls.Add(this.rdoRemoteConn);
            this.grpOS.Controls.Add(this.rdoGetWinVer);
            this.grpOS.Controls.Add(this.rdoGetDBMS);
            this.grpOS.Controls.Add(this.rdoAddAdmin);
            this.grpOS.Location = new System.Drawing.Point(32, 26);
            this.grpOS.Name = "grpOS";
            this.grpOS.Size = new System.Drawing.Size(248, 316);
            this.grpOS.TabIndex = 12;
            this.grpOS.TabStop = false;
            this.grpOS.Text = "OS Admin Options";
            // 
            // rdoReboot
            // 
            this.rdoReboot.AutoSize = true;
            this.rdoReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoReboot.Location = new System.Drawing.Point(16, 273);
            this.rdoReboot.Name = "rdoReboot";
            this.rdoReboot.Size = new System.Drawing.Size(203, 21);
            this.rdoReboot.TabIndex = 11;
            this.rdoReboot.Text = "Reboot Remote Machine";
            this.rdoReboot.UseVisualStyleBackColor = true;
            this.rdoReboot.CheckedChanged += new System.EventHandler(this.rdoReboot_CheckedChanged);
            // 
            // rdoRemoteConn
            // 
            this.rdoRemoteConn.AutoSize = true;
            this.rdoRemoteConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRemoteConn.Location = new System.Drawing.Point(16, 233);
            this.rdoRemoteConn.Name = "rdoRemoteConn";
            this.rdoRemoteConn.Size = new System.Drawing.Size(210, 21);
            this.rdoRemoteConn.TabIndex = 10;
            this.rdoRemoteConn.Text = "Make Remote Connection";
            this.rdoRemoteConn.UseVisualStyleBackColor = true;
            this.rdoRemoteConn.CheckedChanged += new System.EventHandler(this.rdoRemoteConn_CheckedChanged);
            // 
            // rdoGetWinVer
            // 
            this.rdoGetWinVer.AutoSize = true;
            this.rdoGetWinVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetWinVer.Location = new System.Drawing.Point(16, 193);
            this.rdoGetWinVer.Name = "rdoGetWinVer";
            this.rdoGetWinVer.Size = new System.Drawing.Size(180, 21);
            this.rdoGetWinVer.TabIndex = 9;
            this.rdoGetWinVer.Text = "Get Windows Version";
            this.rdoGetWinVer.UseVisualStyleBackColor = true;
            this.rdoGetWinVer.CheckedChanged += new System.EventHandler(this.rdoGetWinVer_CheckedChanged);
            // 
            // rdoGetDBMS
            // 
            this.rdoGetDBMS.AutoSize = true;
            this.rdoGetDBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetDBMS.Location = new System.Drawing.Point(16, 113);
            this.rdoGetDBMS.Name = "rdoGetDBMS";
            this.rdoGetDBMS.Size = new System.Drawing.Size(167, 21);
            this.rdoGetDBMS.TabIndex = 8;
            this.rdoGetDBMS.Text = "Get DBMS Services";
            this.rdoGetDBMS.UseVisualStyleBackColor = true;
            this.rdoGetDBMS.CheckedChanged += new System.EventHandler(this.rdoGetDBMS_CheckedChanged);
            // 
            // rdoGetSW
            // 
            this.rdoGetSW.AutoSize = true;
            this.rdoGetSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGetSW.Location = new System.Drawing.Point(16, 153);
            this.rdoGetSW.Name = "rdoGetSW";
            this.rdoGetSW.Size = new System.Drawing.Size(226, 21);
            this.rdoGetSW.TabIndex = 7;
            this.rdoGetSW.Text = "Get Installed ESRI Software";
            this.rdoGetSW.UseVisualStyleBackColor = true;
            this.rdoGetSW.CheckedChanged += new System.EventHandler(this.rdoGetSW_CheckedChanged);
            // 
            // rdoAddAdmin
            // 
            this.rdoAddAdmin.AutoSize = true;
            this.rdoAddAdmin.Checked = true;
            this.rdoAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAddAdmin.Location = new System.Drawing.Point(16, 33);
            this.rdoAddAdmin.Name = "rdoAddAdmin";
            this.rdoAddAdmin.Size = new System.Drawing.Size(187, 21);
            this.rdoAddAdmin.TabIndex = 6;
            this.rdoAddAdmin.TabStop = true;
            this.rdoAddAdmin.Text = "Add User as an Admin";
            this.rdoAddAdmin.UseVisualStyleBackColor = true;
            this.rdoAddAdmin.CheckedChanged += new System.EventHandler(this.rdoAddAdmin_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConnect);
            this.tabPage2.Controls.Add(this.lblEZConnect);
            this.tabPage2.Controls.Add(this.lblSysPswd);
            this.tabPage2.Controls.Add(this.txtSysPassword);
            this.tabPage2.Controls.Add(this.txtEZCONNECT);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DBMS";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(270, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 39);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(157, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 39);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(383, 422);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 39);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "NEXT >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(44, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 39);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "<< BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(24, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PDB Name";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Close Pluggable";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Delete Pluggable";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Open Pluggable";
            // 
            // txtEZCONNECT
            // 
            this.txtEZCONNECT.Location = new System.Drawing.Point(107, 15);
            this.txtEZCONNECT.Name = "txtEZCONNECT";
            this.txtEZCONNECT.Size = new System.Drawing.Size(122, 20);
            this.txtEZCONNECT.TabIndex = 19;
            // 
            // txtSysPassword
            // 
            this.txtSysPassword.Location = new System.Drawing.Point(107, 48);
            this.txtSysPassword.Name = "txtSysPassword";
            this.txtSysPassword.Size = new System.Drawing.Size(122, 20);
            this.txtSysPassword.TabIndex = 21;
            // 
            // lblSysPswd
            // 
            this.lblSysPswd.AutoSize = true;
            this.lblSysPswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysPswd.Location = new System.Drawing.Point(9, 53);
            this.lblSysPswd.Name = "lblSysPswd";
            this.lblSysPswd.Size = new System.Drawing.Size(97, 13);
            this.lblSysPswd.TabIndex = 22;
            this.lblSysPswd.Text = "SYS Password :";
            // 
            // lblEZConnect
            // 
            this.lblEZConnect.AutoSize = true;
            this.lblEZConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEZConnect.Location = new System.Drawing.Point(9, 17);
            this.lblEZConnect.Name = "lblEZConnect";
            this.lblEZConnect.Size = new System.Drawing.Size(90, 13);
            this.lblEZConnect.TabIndex = 23;
            this.lblEZConnect.Text = "EZCONNECT :";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(121, 80);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 40);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rdoESRIServices
            // 
            this.rdoESRIServices.AutoSize = true;
            this.rdoESRIServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoESRIServices.Location = new System.Drawing.Point(16, 73);
            this.rdoESRIServices.Name = "rdoESRIServices";
            this.rdoESRIServices.Size = new System.Drawing.Size(159, 21);
            this.rdoESRIServices.TabIndex = 12;
            this.rdoESRIServices.Text = "Get ESRI Services";
            this.rdoESRIServices.UseVisualStyleBackColor = true;
            this.rdoESRIServices.CheckedChanged += new System.EventHandler(this.rdoESRIServices_CheckedChanged);
            // 
            // formAdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 467);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl);
            this.Name = "formAdminApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin App";
            this.Load += new System.EventHandler(this.formAdminApp_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpOS.ResumeLayout(false);
            this.grpOS.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpOS;
        private System.Windows.Forms.RadioButton rdoReboot;
        private System.Windows.Forms.RadioButton rdoRemoteConn;
        private System.Windows.Forms.RadioButton rdoGetWinVer;
        private System.Windows.Forms.RadioButton rdoGetDBMS;
        private System.Windows.Forms.RadioButton rdoGetSW;
        private System.Windows.Forms.RadioButton rdoAddAdmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox txtSysPassword;
        private System.Windows.Forms.TextBox txtEZCONNECT;
        private System.Windows.Forms.Label lblEZConnect;
        private System.Windows.Forms.Label lblSysPswd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rdoESRIServices;
    }
}

