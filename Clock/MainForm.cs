using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetVisibility(false);
            labelTime.BackColor = Color.AliceBlue;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            if (cbShowDate.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.ToString("dd.MM.yy");
            }
            if (cbShowWeekDay.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.DayOfWeek.ToString();
            }
            trayIcon.Text = labelTime.Text;
        }

    
        void SetVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            cbShowWeekDay.Visible = visible;
            btnHideControls.Visible = visible;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            this.ShowInTaskbar = visible;
        }
        private void btnHideControls_Click(object sender, EventArgs e)
        {
            cmShowControls.Checked = false;
        }
     
        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show
            //    (
            //    "Вы два раза щелкнули мышью по времени и теперь Вы управляете временем!",
            //    "Info",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //    );
            //MessageBox.Show(
            //    "Шучу, вжух и окно увеличилось",
            //    "Info",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //    );
            SetVisibility (cmShowControls.Checked = true);
        }

       



        private void cmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmTopmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cmTopmost.Checked;
        }

        private void cmShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDate.Checked = cmShowDate.Checked;
        }
        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            cmShowDate.Checked = cbShowDate.Checked;
        }
        private void cmShowWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            cbShowWeekDay.Checked = cmShowWeekDay.Checked;
        }

        private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            cmShowWeekDay.Checked= cbShowWeekDay.Checked;
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        //private void cmCB_Red_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(cmCB_Red.Checked)
        //    {
        //        labelTime.BackColor = Color.Red;
        //        cmCB_Green.Checked = false;
        //        cmCB_Blue.Checked = false;
        //        cmCB_Default.Checked = false;

        //    }
        //    else {
        //        cmCB_Default.Checked = true;
        //        labelTime.BackColor = Color.AliceBlue;
        //    }
        //}

        //private void cmCB_Green_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cmCB_Green.Checked)
        //    {
        //        labelTime.BackColor = Color.Green;
        //        cmCB_Red.Checked = false;
        //        cmCB_Blue.Checked = false;
        //        cmCB_Default.Checked = false;
        //    }
        //    else
        //    {
        //        cmCB_Default.Checked = true;
        //        labelTime.BackColor = Color.AliceBlue;
        //    }
        //}

        //private void cmCB_Blue_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cmCB_Blue.Checked)
        //    {
        //        labelTime.BackColor = Color.Blue;
        //        cmCB_Green.Checked = false;
        //        cmCB_Red.Checked = false;
        //        cmCB_Default.Checked = false;
        //    }
        //    else
        //    {
        //        cmCB_Default.Checked = true;
        //        labelTime.BackColor = Color.AliceBlue;
        //    }
        //}
        void SetBackgroundColor(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Red":     labelTime.BackColor = Color.Red; break;
                case "Green":   labelTime.BackColor = Color.Green; break;
                case "Blue":    labelTime.BackColor = Color.Blue; break;
                case "Default": labelTime.BackColor = Color.AliceBlue; break;
            }
        }
        void SetForegroundColor(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "BlueViolet": labelTime.ForeColor = Color.BlueViolet; break;
                case "SeaShell": labelTime.ForeColor = Color.SeaShell; break;
                case "Snow": labelTime.ForeColor = Color.Snow; break;
                case "Default": labelTime.ForeColor = Color.Black; break;
            }
        }
        private void cmCB_Default_CheckedChanged(object sender, EventArgs e)
        {
                cmCB_Red.Checked = false;
                cmCB_Green.Checked = false;
                cmCB_Blue.Checked = false;
            if (!cmCB_Red.Checked&& !cmCB_Green.Checked && !cmCB_Blue.Checked)
                    {

                        cmCB_Default.Enabled = true;
                        labelTime.BackColor = Color.AliceBlue;
                    }
                }

        private void cmShowControls_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibility(cmShowControls.Checked);
        }
    }
        }
