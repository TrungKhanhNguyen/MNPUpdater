using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MNPUpdate
{
    public partial class Form1 : Form
    {
        private InsertClass cl = new InsertClass();
        public string hexColor = "#e57e31";
        int mov;
        int movX;
        int movY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);
             btnTimerStart.BackColor = myColor;
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
            
        }


        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            var timer1Number = Convert.ToInt32(txtDailyTimer.Text) * 60 * 1000;
            var timer2Number = Convert.ToInt32(txtBulkTimer.Text) * 60 * 1000;
            timer1.Interval = timer1Number;
            timer2.Interval = timer2Number;
            timer1.Start();
            timer2.Start();
            btnTimerStop.Enabled = true;
            btnTimerStart.Enabled = false;
        }

        private void ExecuteFile(string source, string destination, string fileName)
        {
            try
            {
                var sourcefile = source + @"\" + fileName;
                var destinationfile = destination + @"\" + fileName;
                ProcessFile(sourcefile);
                File.Copy(sourcefile, destinationfile);
            }
            catch
            {
                MessageBox.Show(this, "Lỗi", "Error Message!");
            }
            
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            btnTimerStart.Enabled = true;
            btnTimerStop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtDailyIn.Text);
            DirectoryInfo[] x = directory.GetDirectories();
            var dirname = x[0].Name;
            foreach (var item in x)
            {
                var destinationPath = Path.Combine(txtDailyOut.Text, item.Name);
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                    var fileEntriesInput = Directory.GetFiles(item.FullName).Select(Path.GetFileName).ToList();
                    if (fileEntriesInput != null && fileEntriesInput.Count > 0)
                    {
                        foreach (var file in fileEntriesInput)
                        {
                            ExecuteFile(item.FullName, destinationPath, file);
                        }
                    }
                }
                else
                {
                    var fileEntriesOutput = Directory.GetFiles(destinationPath).Select(Path.GetFileName).ToList();
                    var fileEntriesInput = Directory.GetFiles(item.FullName).Select(Path.GetFileName).ToList();

                    if (fileEntriesInput != null && fileEntriesInput.Count > 0)
                    {
                        foreach (var itemOutput in fileEntriesOutput)
                        {
                            var tempItem = fileEntriesInput.Where(m => m.ToLower().Trim() == itemOutput.ToLower().Trim()).FirstOrDefault();
                            if (tempItem != null)
                                fileEntriesInput.Remove(tempItem);
                        }
                    }
                    foreach (var itemInput in fileEntriesInput)
                    {
                        ExecuteFile(item.FullName, destinationPath, itemInput);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        #region [ProcessFile]
        
        private void ProcessFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            if(lines.Length > 1) {
                foreach (string line in lines)
                {
                    if(!line.Contains("Count of"))
                    {
                        try
                        {
                            ProcessLine(line);
                        }
                        catch
                        {

                        }
                    }
                }
            }
            
        }

        private void ProcessLine(string line)
        {
            String[] listStr = line.Split(',');
            DateTime requestDate ;
            string actionType = "", msisdn = "", route = "", recipient = "", donor = "",blockHolder = "";
            DateTime startDate;
            string textDate = "", textEndDate = "";
            if (listStr != null && listStr.Length > 0)
            {
                textDate = listStr[0].Substring(0,14);
                actionType = listStr[2];
                msisdn = listStr[3];
                route = listStr[4];
                recipient = listStr[5];
                donor = listStr[6];
                blockHolder = listStr[7];
                textEndDate = listStr[8];
                requestDate = DateTime.ParseExact(textDate,"yyyyMMddHHmmss",CultureInfo.InvariantCulture);
                startDate = Convert.ToDateTime(textEndDate);
                cl.InsertCELL(requestDate,actionType,msisdn,route,recipient,donor,blockHolder,startDate);
               }
        }
        #endregion
        #region [BulkFiles]
        private void UpdateBulkFiles(string sourceDirectory, string targetDirectory)
        {

        }
        #endregion
        #region [Drag Form]
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        #endregion  
        #region [Folder Open]
        private void btnBulkIn_Click(object sender, EventArgs e)
        {
            var temp = "";
            FolderBrowserDialog dia = new FolderBrowserDialog();
            dia.RootFolder = Environment.SpecialFolder.Desktop;
            dia.Description = "+++Select Folder+++";
            dia.ShowNewFolderButton = false;
            if (dia.ShowDialog() == DialogResult.OK)
            {
                temp = dia.SelectedPath;
                txtBulkIn.Text = temp;
            }
        }

        private void btnBulkOut_Click(object sender, EventArgs e)
        {
            var temp = "";
            FolderBrowserDialog dia = new FolderBrowserDialog();
            dia.RootFolder = Environment.SpecialFolder.Desktop;
            dia.Description = "+++Select Folder+++";
            dia.ShowNewFolderButton = false;
            if (dia.ShowDialog() == DialogResult.OK)
            {
                temp = dia.SelectedPath;
                txtBulkOut.Text = temp;
            }
        }

        private void btnDailyIn_Click(object sender, EventArgs e)
        {
            var temp = "";
            FolderBrowserDialog dia = new FolderBrowserDialog();
            dia.RootFolder = Environment.SpecialFolder.Desktop;
            dia.Description = "+++Select Folder+++";
            dia.ShowNewFolderButton = false;
            if (dia.ShowDialog() == DialogResult.OK)
            {
                temp = dia.SelectedPath;
                txtDailyIn.Text = temp;
            }
        }

        private void btnDailyOut_Click(object sender, EventArgs e)
        {
            var temp = "";
            FolderBrowserDialog dia = new FolderBrowserDialog();
            dia.RootFolder = Environment.SpecialFolder.Desktop;
            dia.Description = "+++Select Folder+++";
            dia.ShowNewFolderButton = false;
            if (dia.ShowDialog() == DialogResult.OK)
            {
                temp = dia.SelectedPath;
                txtDailyOut.Text = temp;
            }
        }
        #endregion
        private void timer2_Tick(object sender, EventArgs e)
        {
            var fileEntriesOutput = Directory.GetFiles(txtBulkOut.Text).Select(Path.GetFileName).ToList();
            var fileEntriesInput = Directory.GetFiles(txtBulkIn.Text).Select(Path.GetFileName).ToList();

            if (fileEntriesInput != null && fileEntriesInput.Count > 0)
            {
                foreach (var itemOutput in fileEntriesOutput)
                {
                    var tempItem = fileEntriesInput.Where(m => m.ToLower().Trim() == itemOutput.ToLower().Trim()).FirstOrDefault();
                    if (tempItem != null)
                        fileEntriesInput.Remove(tempItem);
                }
            }
            foreach (var itemInput in fileEntriesInput)
            {
                ExecuteFile(txtBulkIn.Text, txtBulkOut.Text, itemInput);
            }
        }
    }
}
