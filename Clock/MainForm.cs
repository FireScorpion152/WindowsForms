using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            if (cbShowDate.Checked)
            {
                labelTime.Text += "\n";
                labelTime.Text += DateTime.Now.ToString("dd.MM.yy");
            }
        }

        private void CheckBoxShowDate_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            cbShowDate.Visible  = false;
            btnHideControls.Visible = false;
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None;
            labelTime.BackColor = Color.AliceBlue;
            this.ShowInTaskbar = false;
        }

        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "Вы два раза щелкнули мышью по времени и теперь Вы управляете временем!",
                "Info",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
                );
            MessageBox.Show(
                "Шучу, вжух и окно увеличилось",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.TransparencyKey = Color.Transparent;
            labelTime.BackColor = default;
            cbShowDate.Visible = true;
            btnHideControls.Visible = true;
            this.ShowInTaskbar = true;
        }
    }
}
