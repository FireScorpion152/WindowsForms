using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            labelTime.BackColor = Color.AliceBlue;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
        }
        void CustomFonts()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile(Path.Combine(Application.StartupPath, "a_AlternaSw.ttf"));

            labelTime.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);

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

    
        void SetVisability(bool visible)
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
            SetVisability(false);
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
            SetVisability (true);
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

        //private void cmCB_Click(object sender, EventArgs e)
        //{
        //    ColorDialog dialog = new ColorDialog();
        //    dialog.Color = labelTime.BackColor;
        //    if(dialog.ShowDialog() == DialogResult.OK)
        //    labelTime.BackColor = dialog.Color;
        //}

        //private void cmCF_Click(object sender, EventArgs e)
        //{
        //    ColorDialog dialog = new ColorDialog();
        //    dialog.Color = labelTime.ForeColor;
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //        labelTime.ForeColor = dialog.Color;
        //}
        private void SetColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Background color": dialog.Color = labelTime.BackColor; break;
                case "Foreground color": dialog.Color = labelTime.ForeColor; break;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch ((sender as ToolStripMenuItem).Text)
                {
                    case "Background color":labelTime.BackColor = dialog.Color; break;
                    case "Foreground color":labelTime.ForeColor = dialog.Color; break;
                }
            }
               
        }
    }
}
