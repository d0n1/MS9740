namespace DeviceControl
{
    partial class frmMain
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
            this.lblSN = new System.Windows.Forms.Label();
            this.lblWO = new System.Windows.Forms.Label();
            this.lblLocalDir = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtArchivedDir = new System.Windows.Forms.TextBox();
            this.txtOSAIP = new System.Windows.Forms.TextBox();
            this.txtOSADir = new System.Windows.Forms.TextBox();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderbrowser = new System.Windows.Forms.Button();
            this.lblFileFormat = new System.Windows.Forms.Label();
            this.chkboxImg = new System.Windows.Forms.CheckBox();
            this.chkboxCSV = new System.Windows.Forms.CheckBox();
            this.chkboxXML = new System.Windows.Forms.CheckBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkboxRepeat = new System.Windows.Forms.CheckBox();
            this.chkboxSingle = new System.Windows.Forms.CheckBox();
            this.chkboxAuto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxNo = new System.Windows.Forms.CheckBox();
            this.chkboxYes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnSuffix = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTimestmp = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(5, 41);
            this.lblSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(101, 17);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "Serial No. (SN):";
            // 
            // lblWO
            // 
            this.lblWO.AutoSize = true;
            this.lblWO.Location = new System.Drawing.Point(5, 91);
            this.lblWO.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWO.Name = "lblWO";
            this.lblWO.Size = new System.Drawing.Size(120, 17);
            this.lblWO.TabIndex = 2;
            this.lblWO.Text = "Work Order (WO):";
            // 
            // lblLocalDir
            // 
            this.lblLocalDir.AutoSize = true;
            this.lblLocalDir.Location = new System.Drawing.Point(4, 286);
            this.lblLocalDir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLocalDir.Name = "lblLocalDir";
            this.lblLocalDir.Size = new System.Drawing.Size(126, 17);
            this.lblLocalDir.TabIndex = 3;
            this.lblLocalDir.Text = "Archived Directory:";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(4, 189);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(87, 17);
            this.lblAddr.TabIndex = 4;
            this.lblAddr.Text = "OSA IP Addr:";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(127, 41);
            this.txtSN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(180, 23);
            this.txtSN.TabIndex = 5;
            this.txtSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSN_KeyPress);
            // 
            // txtWO
            // 
            this.txtWO.Location = new System.Drawing.Point(127, 91);
            this.txtWO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(182, 23);
            this.txtWO.TabIndex = 6;
            // 
            // txtArchivedDir
            // 
            this.txtArchivedDir.Location = new System.Drawing.Point(127, 283);
            this.txtArchivedDir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtArchivedDir.Name = "txtArchivedDir";
            this.txtArchivedDir.Size = new System.Drawing.Size(182, 23);
            this.txtArchivedDir.TabIndex = 7;
            // 
            // txtOSAIP
            // 
            this.txtOSAIP.Location = new System.Drawing.Point(127, 189);
            this.txtOSAIP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOSAIP.Name = "txtOSAIP";
            this.txtOSAIP.Size = new System.Drawing.Size(182, 23);
            this.txtOSAIP.TabIndex = 8;
            // 
            // txtOSADir
            // 
            this.txtOSADir.Location = new System.Drawing.Point(127, 233);
            this.txtOSADir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOSADir.Name = "txtOSADir";
            this.txtOSADir.Size = new System.Drawing.Size(182, 23);
            this.txtOSADir.TabIndex = 10;
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(4, 236);
            this.lblSourceFolder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(98, 17);
            this.lblSourceFolder.TabIndex = 9;
            this.lblSourceFolder.Text = "OSA Directory:";
            // 
            // btnFolderbrowser
            // 
            this.btnFolderbrowser.Location = new System.Drawing.Point(310, 283);
            this.btnFolderbrowser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFolderbrowser.Name = "btnFolderbrowser";
            this.btnFolderbrowser.Size = new System.Drawing.Size(40, 23);
            this.btnFolderbrowser.TabIndex = 13;
            this.btnFolderbrowser.UseVisualStyleBackColor = true;
            this.btnFolderbrowser.Click += new System.EventHandler(this.btnFolderbrowser_Click);
            // 
            // lblFileFormat
            // 
            this.lblFileFormat.AutoSize = true;
            this.lblFileFormat.Location = new System.Drawing.Point(4, 95);
            this.lblFileFormat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFileFormat.Name = "lblFileFormat";
            this.lblFileFormat.Size = new System.Drawing.Size(81, 17);
            this.lblFileFormat.TabIndex = 14;
            this.lblFileFormat.Text = "File Format:";
            // 
            // chkboxImg
            // 
            this.chkboxImg.AutoSize = true;
            this.chkboxImg.Location = new System.Drawing.Point(254, 95);
            this.chkboxImg.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxImg.Name = "chkboxImg";
            this.chkboxImg.Size = new System.Drawing.Size(85, 21);
            this.chkboxImg.TabIndex = 15;
            this.chkboxImg.Text = "png/bmp";
            this.chkboxImg.UseVisualStyleBackColor = true;
            // 
            // chkboxCSV
            // 
            this.chkboxCSV.AutoSize = true;
            this.chkboxCSV.Location = new System.Drawing.Point(126, 95);
            this.chkboxCSV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxCSV.Name = "chkboxCSV";
            this.chkboxCSV.Size = new System.Drawing.Size(46, 21);
            this.chkboxCSV.TabIndex = 16;
            this.chkboxCSV.Text = "csv";
            this.chkboxCSV.UseVisualStyleBackColor = true;
            // 
            // chkboxXML
            // 
            this.chkboxXML.AutoSize = true;
            this.chkboxXML.Location = new System.Drawing.Point(187, 95);
            this.chkboxXML.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxXML.Name = "chkboxXML";
            this.chkboxXML.Size = new System.Drawing.Size(50, 21);
            this.chkboxXML.TabIndex = 17;
            this.chkboxXML.Text = "xml";
            this.chkboxXML.UseVisualStyleBackColor = true;
            // 
            // grpSettings
            // 
            this.grpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.grpSettings.Controls.Add(this.label20);
            this.grpSettings.Controls.Add(this.label9);
            this.grpSettings.Controls.Add(this.label16);
            this.grpSettings.Controls.Add(this.label15);
            this.grpSettings.Controls.Add(this.label14);
            this.grpSettings.Controls.Add(this.label13);
            this.grpSettings.Controls.Add(this.label12);
            this.grpSettings.Controls.Add(this.label11);
            this.grpSettings.Controls.Add(this.label10);
            this.grpSettings.Controls.Add(this.label6);
            this.grpSettings.Controls.Add(this.label5);
            this.grpSettings.Controls.Add(this.label4);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.chkboxRepeat);
            this.grpSettings.Controls.Add(this.chkboxSingle);
            this.grpSettings.Controls.Add(this.chkboxAuto);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.chkboxNo);
            this.grpSettings.Controls.Add(this.chkboxYes);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.lblSourceFolder);
            this.grpSettings.Controls.Add(this.btnFolderbrowser);
            this.grpSettings.Controls.Add(this.chkboxXML);
            this.grpSettings.Controls.Add(this.txtOSADir);
            this.grpSettings.Controls.Add(this.chkboxCSV);
            this.grpSettings.Controls.Add(this.txtArchivedDir);
            this.grpSettings.Controls.Add(this.lblAddr);
            this.grpSettings.Controls.Add(this.chkboxImg);
            this.grpSettings.Controls.Add(this.txtOSAIP);
            this.grpSettings.Controls.Add(this.lblLocalDir);
            this.grpSettings.Controls.Add(this.lblFileFormat);
            this.grpSettings.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpSettings.Location = new System.Drawing.Point(11, 173);
            this.grpSettings.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpSettings.Size = new System.Drawing.Size(355, 333);
            this.grpSettings.TabIndex = 18;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(280, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 42;
            this.label20.Text = "图片";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "设置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "源路径";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "OSA IP 地址";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "存档路径";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "重复扫描";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "只扫一次";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "自动";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "扫描模式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "文件格式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "否";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "是";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "保存文件";
            // 
            // chkboxRepeat
            // 
            this.chkboxRepeat.AutoSize = true;
            this.chkboxRepeat.Location = new System.Drawing.Point(254, 142);
            this.chkboxRepeat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxRepeat.Name = "chkboxRepeat";
            this.chkboxRepeat.Size = new System.Drawing.Size(69, 21);
            this.chkboxRepeat.TabIndex = 24;
            this.chkboxRepeat.Text = "Repeat";
            this.chkboxRepeat.UseVisualStyleBackColor = true;
            this.chkboxRepeat.CheckedChanged += new System.EventHandler(this.chkboxRepeat_CheckedChanged);
            // 
            // chkboxSingle
            // 
            this.chkboxSingle.AutoSize = true;
            this.chkboxSingle.Location = new System.Drawing.Point(187, 142);
            this.chkboxSingle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxSingle.Name = "chkboxSingle";
            this.chkboxSingle.Size = new System.Drawing.Size(65, 21);
            this.chkboxSingle.TabIndex = 23;
            this.chkboxSingle.Text = "Single";
            this.chkboxSingle.UseVisualStyleBackColor = true;
            this.chkboxSingle.CheckedChanged += new System.EventHandler(this.chkboxSingle_CheckedChanged);
            // 
            // chkboxAuto
            // 
            this.chkboxAuto.AutoSize = true;
            this.chkboxAuto.Location = new System.Drawing.Point(126, 142);
            this.chkboxAuto.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxAuto.Name = "chkboxAuto";
            this.chkboxAuto.Size = new System.Drawing.Size(57, 21);
            this.chkboxAuto.TabIndex = 22;
            this.chkboxAuto.Text = "Auto";
            this.chkboxAuto.UseVisualStyleBackColor = true;
            this.chkboxAuto.CheckedChanged += new System.EventHandler(this.chkboxAuto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sweep Mode:";
            // 
            // chkboxNo
            // 
            this.chkboxNo.AutoSize = true;
            this.chkboxNo.Location = new System.Drawing.Point(187, 48);
            this.chkboxNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxNo.Name = "chkboxNo";
            this.chkboxNo.Size = new System.Drawing.Size(45, 21);
            this.chkboxNo.TabIndex = 20;
            this.chkboxNo.Text = "No";
            this.chkboxNo.UseVisualStyleBackColor = true;
            this.chkboxNo.CheckedChanged += new System.EventHandler(this.chkboxNo_CheckedChanged);
            // 
            // chkboxYes
            // 
            this.chkboxYes.AutoSize = true;
            this.chkboxYes.Location = new System.Drawing.Point(126, 48);
            this.chkboxYes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkboxYes.Name = "chkboxYes";
            this.chkboxYes.Size = new System.Drawing.Size(48, 21);
            this.chkboxYes.TabIndex = 19;
            this.chkboxYes.Text = "Yes";
            this.chkboxYes.UseVisualStyleBackColor = true;
            this.chkboxYes.CheckedChanged += new System.EventHandler(this.chkboxYes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Save File:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(836, 116);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(133, 56);
            this.btnApply.TabIndex = 43;
            this.btnApply.Text = "Apply Setting\r\n保存及应用设置";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.SystemColors.Control;
            this.grpInfo.Controls.Add(this.btnSuffix);
            this.grpInfo.Controls.Add(this.label17);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtWO);
            this.grpInfo.Controls.Add(this.txtSN);
            this.grpInfo.Controls.Add(this.lblWO);
            this.grpInfo.Controls.Add(this.lblSN);
            this.grpInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grpInfo.Location = new System.Drawing.Point(11, 25);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpInfo.Size = new System.Drawing.Size(355, 136);
            this.grpInfo.TabIndex = 19;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Product Information";
            // 
            // btnSuffix
            // 
            this.btnSuffix.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSuffix.Location = new System.Drawing.Point(310, 41);
            this.btnSuffix.Name = "btnSuffix";
            this.btnSuffix.Size = new System.Drawing.Size(40, 23);
            this.btnSuffix.TabIndex = 41;
            this.btnSuffix.UseVisualStyleBackColor = true;
            this.btnSuffix.Click += new System.EventHandler(this.btnSuffix_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "产品信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "生产工令";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "生产序号";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(369, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "333";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(977, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(836, 188);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 56);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse\r\n打开文件所在目录";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(836, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(133, 56);
            this.btnRun.TabIndex = 45;
            this.btnRun.Text = "Start Now\r\n开始";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(836, 448);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "Timestamp 测试时间：";
            // 
            // lblTimestmp
            // 
            this.lblTimestmp.AutoSize = true;
            this.lblTimestmp.Location = new System.Drawing.Point(836, 465);
            this.lblTimestmp.Name = "lblTimestmp";
            this.lblTimestmp.Size = new System.Drawing.Size(0, 17);
            this.lblTimestmp.TabIndex = 47;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(977, 539);
            this.Controls.Add(this.lblTimestmp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpSettings);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "MS9740 OSA File Capturer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenCapture_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenCapture_FormClosed);
            this.Load += new System.EventHandler(this.ScreenCapture_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblWO;
        private System.Windows.Forms.Label lblLocalDir;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtArchivedDir;
        private System.Windows.Forms.TextBox txtOSAIP;
        private System.Windows.Forms.TextBox txtOSADir;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderbrowser;
        private System.Windows.Forms.Label lblFileFormat;
        private System.Windows.Forms.CheckBox chkboxImg;
        private System.Windows.Forms.CheckBox chkboxCSV;
        private System.Windows.Forms.CheckBox chkboxXML;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.CheckBox chkboxRepeat;
        private System.Windows.Forms.CheckBox chkboxSingle;
        private System.Windows.Forms.CheckBox chkboxAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkboxNo;
        private System.Windows.Forms.CheckBox chkboxYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSuffix;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTimestmp;
    }
}

