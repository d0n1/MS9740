using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace DeviceControl
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        OSA MS9740 = new OSA();
        NetworkMapping MS9740Mapping = new NetworkMapping();
        ConfigSetting config= new ConfigSetting();

        //string fileFormat;
        string fileName;
        string newFileName;
        string folderWO;
        string strArchivedDir;
        string strOSAIP;
        string strDriver;
        string strOSADir;
        int channelNum = 3;
        //int delayTime = 7;
        
        //DO NOT change below variable if unnecessary
        string userName = "administrator";
        string password = "af0p";
        //string Driver=@"Z:";
        //string OSADir = @"\D$\Anritsu Corporation\Optical Spectrum Analyzer\User Data";

        private void Delay(double seconds)
        {
            DateTime tempTime = DateTime.Now;
            while (tempTime.AddSeconds(seconds).CompareTo(DateTime.Now)>0)
            {
                Application.DoEvents();
            }
        }

        private void btnFolderbrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivedDir.Text = folderBrowserDialog1.SelectedPath;
                //strArchivedDir = txtArchivedDir.Text ;
            }
        }

        private void MapInstr()
        {
            try
            {
                string remotePath = @"\\" + strOSAIP + strOSADir;
                //strOSADir=@"\\"+strOSAIP+strOSADir;

                //Setting for network mapping
                MS9740Mapping.LocalDriver = strDriver;
                MS9740Mapping.RemotePath = remotePath;

                //Unmap 
                if (Directory.Exists(strDriver))
                {
                    MS9740Mapping.UnMapDrivers(true);
                }
                
                MS9740Mapping.MapDrivers(userName, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not mapping to local" + ex.ToString());
             }
        }

        private void UnmapInstr()
        {
            try
            {
                string remotePath = @"\\" + strOSAIP + strOSADir;
                MS9740Mapping.LocalDriver = strDriver;
                MS9740Mapping.RemotePath = remotePath;
                MS9740Mapping.UnMapDrivers(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not mapping to local" + ex.ToString());
            }
        }

        private void LinkInstr()
        {
            //setting for osa address.
            MS9740.resrcAddr = strOSAIP;

            MS9740.CloseInstr();

            if (MS9740.OpenInstr())
            {
                //initialize the OSA first
                MS9740.PreSet();
                Delay(2);
            }
            else
            {
                throw new Exception("Link Fail!! Pls check the GPIB/IP address and network cable!!\n\r"
                                    + "连接不成功！请检查GPIB/IP地址或网络是否连通！！");
            }

        }

        private void UnlinkInstr()
        {
            MS9740.CloseInstr();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            string appPath = Environment.CurrentDirectory;
            pictureBox1.Image = null;
            try
            {
                //grpInfo.Enabled = false;
                //grpSettings.Enabled = false;
                txtSN.Enabled = false;
                txtWO.Enabled = false;
                txtOSAIP.Enabled = false;
                txtArchivedDir.Enabled = false;
                btnSuffix.Enabled = false;
                btnFolderbrowser.Enabled = false;
                btnRun.Enabled = false;
                //chekc if SN, WO is empty
                if (txtSN.Text == "" || txtWO.Text == "")
                {
                    throw new Exception("Pls input a correct SN or WO!!\n\r"
                                        + "请输入正确的SN和WO!!");
                }
                else
                {
                    //strOSAIP = txtOSAIP.Text;
                    fileName = txtSN.Text + btnSuffix.Text;
                    folderWO = txtWO.Text;
                }
                //check if GPIB/IP addr, Source/Destination Folder is empty
                if (txtOSAIP.Text == "" || txtOSADir.Text == "" || txtArchivedDir.Text == "")
                {
                    throw new Exception("Pls check the GPIB/IP address and OSA/Archived Directory!!\n\r"
                                        + "请检查GIPB/IP地址、源路径、存档路径是否正确！！" );
                }
                //else
                //{
                //    strOSADir=txtOSADir.Text;
                //    strArchivedDir=txtArchivedDir.Text;
                //}

                // Link OSA
                toolStripStatusLabel1.Text = ">>>Linking instrument,pls wait......正在连接OSA.";
                LinkInstr();
                toolStripStatusLabel1.Text = ">>>Link instrument completed......连接成功！";

                //Map OSA
                if (!Directory.Exists(strDriver))
                {
                    toolStripStatusLabel1.Text = ">>>Mapping instrument......正在映射网络.";
                    MapInstr();
                    toolStripStatusLabel1.Text = ">>>Map instrument completed......映射成功!";
                }
               
                // select sweep mode
                toolStripStatusLabel1.Text = ">>>Sweeping spretrum.......正在扫谱.";
                if (chkboxAuto.Checked)
                {
                    MS9740.Sweep(0);
                    Delay(7);
                }
                else if (chkboxSingle.Checked)
                {
                    MS9740.Sweep(1);
                    Delay(7);
                }
                else if (chkboxRepeat.Checked)
                {
                    MS9740.Sweep(2);
                    Delay(7);
                    //MS9740.PeakSearch();  
                }
                else
                {
                    throw new Exception("Pls select a Sweep Mode: Auto, Single or Repeat!!\n\r"
                                        + "请选择一个扫描方式：自动、只扫一次或重复扫描！！");
                }
                //Add Peak search
                MS9740.PeakSearch();
                //Delay(5);
                toolStripStatusLabel1.Text = ">>>Sweep spretrum completed.....扫谱完成.";
                
                //Save to file or not
                if (chkboxYes.Checked)
                {
                    strArchivedDir = txtArchivedDir.Text + "\\" + folderWO;
                    
                    if (!Directory.Exists(strArchivedDir))
                    {
                        Directory.CreateDirectory(strArchivedDir);
                    }

                    if (!(chkboxImg.Checked || chkboxCSV.Checked || chkboxXML.Checked))
                    {
                        throw new Exception("Pls select a file format at least: csv, xml png/bmp!!\n\r"
                                            + "请至少选择一个文件格式：csv、xml、png/bmp!!");
                    }

                    //check file format and save it to local PC then delete it 
                    if (chkboxCSV.Checked)
                    {
                        
                        MS9740.SaveDataToFile("csv", fileName);
                        toolStripStatusLabel1.Text = ">>>Saving CSV file......正在保存CSV文件.";
                        Delay(3);
                        if (File.Exists(strArchivedDir + "\\" + fileName + ".csv"))
                        {
                            int i;
                            for (i = 2; i < 21; i++)
                            {
                                if (!File.Exists(strArchivedDir + "\\" + fileName + "(" + i + ")" + ".csv"))
                                {
                                    newFileName = fileName + "(" + i + ")";
                                    break;
                                }
                            }
                            if (i == 21)
                            {
                                throw new Exception("There are more than 20 files in this SN, pls delete some..\n\r" +
                                                    "该SN已经测试超过20次，请删除一些没用的文件再继续测试。。");
                            }
                        }
                        else
                        {
                            newFileName = fileName;
                        }
                        File.Copy(strDriver + @"\CSV Data\" + fileName + ".csv", strArchivedDir + "\\" + newFileName + ".csv", true);
                        Delay(2);
                        File.Delete(strDriver + @"\CSV Data\" + fileName + ".csv");
                        //Delay(1.5);
                        toolStripStatusLabel1.Text = ">>>Save CSV file completed......保存成功.";
                        //MS9740.DeleteDataFromFile("csv", fileName);
                    }
                    if (chkboxXML.Checked)
                    {
                        MS9740.SaveDataToFile("xml", fileName);
                        toolStripStatusLabel1.Text = ">>>Saving XML file......正在保存XML文件.";
                        Delay(3);
                        if (File.Exists(strArchivedDir + "\\" + fileName + ".xml"))
                        {
                            int i;
                            for (i = 2; i < 21; i++)
                            {
                                if (!File.Exists(strArchivedDir + "\\" + fileName + "(" + i + ")" + ".xml"))
                                {
                                    newFileName = fileName + "(" + i + ")";
                                    break;
                                }
                            }
                            if (i == 21)
                            {
                                throw new Exception("There are more than 20 files in this SN, pls delete some..\n\r" +
                                                    "该SN已经测试超过20次，请删除一些没用的文件再继续测试。。");
                            }
                        }
                        else
                        {
                            newFileName = fileName;
                        }
                        File.Copy(strDriver + @"\All Trace Data\" + fileName + ".xml", strArchivedDir + "\\" + newFileName + ".xml", true);
                        Delay(2);
                        File.Delete(strDriver + @"\All Trace Data\" + fileName + ".xml");
                        //Delay(1.5);
                        toolStripStatusLabel1.Text = "Save XML file completed......保存成功.";
                        //MS9740.DeleteDataFromFile("xml", fileName);
                    }
                    if (chkboxImg.Checked)
                    {
                        MS9740.SaveDataToFile("png", fileName);
                        toolStripStatusLabel1.Text = ">>>Saving PNG file......正在保存PNG文件.";
                        Delay(3);
                        if (File.Exists(strArchivedDir + "\\" + fileName + ".png"))
                        {
                            int i;
                            for (i = 2; i < 21; i++)
                            {
                                if (!File.Exists(strArchivedDir + "\\" + fileName + "(" + i + ")" + ".png"))
                                {
                                    newFileName = fileName + "(" + i + ")";
                                    break;
                                }
                            }
                            if (i == 21)
                            {
                                throw new Exception("There are more than 20 files in this SN, pls delete some..\n\r" +
                                                    "该SN已经测试超过20次，请删除一些没用的文件再继续测试。。");
                            }
                        }
                        else
                        {
                            newFileName = fileName;
                        }
                        File.Copy(strDriver + @"\Screenshot\" + fileName + ".png", strArchivedDir + "\\" + newFileName + ".png", true);
                        Delay(2);
                        File.Delete(strDriver + @"\Screenshot\" + fileName + ".png");
                        //Delay(1.5);
                        toolStripStatusLabel1.Text = ">>>Save file completed......保存成功.";
                        //MS9740.DeleteDataFromFile("png", fileName);
                        pictureBox1.Image = Image.FromFile(strArchivedDir + "\\" + newFileName + ".png");
                    }
                    if (!chkboxImg.Checked)
                    {
                        pictureBox1.Image = Image.FromFile(appPath + "\\" + "OK.jpg");
                    }
                    lblTimestmp.Text = DateTime.Now.ToString();
                }
                toolStripStatusLabel1.Text = ">>>Scan complete......扫谱完成.";
                btnRun.Enabled = true;
                txtSN.Enabled = true;
                txtWO.Enabled = true;
                txtOSAIP.Enabled = true;
                txtArchivedDir.Enabled = true;
                btnSuffix.Enabled = true;
                //grpInfo.Enabled = true;
                //grpSettings.Enabled = true;
                btnFolderbrowser.Enabled = true;
                txtSN.Focus();
                UseWaitCursor = false;
            }

            catch (Exception ex)
            {
                //MessageBox.Show("An error occurred: " + ex.Message);
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRun.Enabled = true;
                btnSuffix.Enabled = true;
                btnFolderbrowser.Enabled = true;
                txtSN.Enabled = true;
                txtWO.Enabled = true;
                txtOSAIP.Enabled = true;
                txtArchivedDir.Enabled = true;
                //grpInfo.Enabled = true;
                //grpSettings.Enabled = true;
                UseWaitCursor = false;
                pictureBox1.Image = Image.FromFile(appPath + "\\" + "NG.jpg"); 
                //MessageBox.Show("An error occurred: "+ ex.ToString());
            }
        }

        #region checkbox setting
        private void chkboxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxYes.Checked)
            {
                chkboxNo.Checked = false;
            }
            //else
            //{
            //    chkboxNo.Checked = true;
            //}
        }

        private void chkboxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxNo.Checked)
            {
                chkboxYes.Checked = false;
            }
            //else
            //{
            //    chkboxYes.Checked = true;
            //}
        }

        private void chkboxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxAuto.Checked)
            {
                chkboxRepeat.Checked = false;
                chkboxSingle.Checked = false;
            }
        }

        private void chkboxSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSingle.Checked)
            {
                chkboxRepeat.Checked = false;
                chkboxAuto.Checked = false;
            }
        }

        private void chkboxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxRepeat.Checked)
            {
                chkboxSingle.Checked = false;
                chkboxAuto.Checked = false;
            }
        }
        #endregion

        private void ScreenCapture_Load(object sender, EventArgs e)
        {
            //chkboxYes.Checked = true;
            //chkboxImg.Checked = true;
            //chkboxAuto.Checked = true;
            //txtOSAIP.Text = "192.168.208.166";
            //txtOSADir.Text = @"\D$\Anritsu Corporation\Optical Spectrum Analyzer\User Data";
            //txtArchivedDir.Text = @"D:\OSA";
            txtOSADir.ReadOnly = true;
            ReadConfig();
            toolStripStatusLabel1.Text = ">>>Ready......";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (!File.Exists(strArchivedDir))
            {
                System.Diagnostics.Process.Start("explorer.exe", strArchivedDir);
            }
            else
            {
                System.Diagnostics.Process.Start("explorer.exe", @"/select, " + strArchivedDir);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Write config
            WriteConfig();
            //Read config
            ReadConfig();
            
        }

        private void WriteConfig()
        {
            config.SetConfig("MapDriver", "Z:");
            config.SetConfig("OSAIP", txtOSAIP.Text);
            config.SetConfig("OSADir", txtOSADir.Text);
            config.SetConfig("ArchivedDir", txtArchivedDir.Text);
            config.SetConfig("IsSaveFile", chkboxYes.Checked.ToString());

            config.SetConfig("csv", chkboxCSV.Checked.ToString());
            config.SetConfig("xml", chkboxXML.Checked.ToString());
            config.SetConfig("img", chkboxImg.Checked.ToString());

            if (chkboxAuto.Checked)
            {
                config.SetConfig("SweepMode", "Auto");
            }
            else if (chkboxRepeat.Checked)
            {
                config.SetConfig("SweepMode", "Repeat");
            }
            else if (chkboxSingle.Checked)
            {
                config.SetConfig("SweepMode", "Single");
            }
            else
            {
                config.SetConfig("SweepMode", "");
            }
        }

        private void ReadConfig()
        {
            strDriver = config.GetConfig("MapDriver");
            strOSAIP = txtOSAIP.Text = config.GetConfig("OSAIP");
            strArchivedDir = txtArchivedDir.Text = config.GetConfig("ArchivedDir");
            strOSADir = txtOSADir.Text = config.GetConfig("OSADir");

            chkboxYes.Checked = (config.GetConfig("IsSaveFile") == "True");
            chkboxNo.Checked = (config.GetConfig("IsSaveFile")=="False");
            chkboxAuto.Checked = (config.GetConfig("SweepMode") == "Auto");
            chkboxRepeat.Checked = (config.GetConfig("SweepMode") == "Repeat");
            chkboxSingle.Checked = (config.GetConfig("SweepMode") == "Single");

            chkboxCSV.Checked = (config.GetConfig("csv") == "True");
            chkboxXML.Checked = (config.GetConfig("xml") == "True");
            chkboxImg.Checked = (config.GetConfig("img") == "True");
        }

        private void IncreaseChannelNum()
        {
            channelNum--;
            if (channelNum <0)
            {
                channelNum = 3;
            }  
        }

        private void ScreenCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnlinkInstr();
            UnmapInstr();
        }

        private void ScreenCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show(this, "Are you sure to close the form??\n\r" + "确定要退出？？", "Warning");
            DialogResult dr = MessageBox.Show("Are you sure to close the form?\n\r确定要退出程序？",
                                                "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else 
            {
                e.Cancel = true;
            }
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            btnSuffix.Text = "-L"+channelNum.ToString();
            IncreaseChannelNum();
        }

        private void txtSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnRun_Click(null,null);
            }
        }
    }
}
 