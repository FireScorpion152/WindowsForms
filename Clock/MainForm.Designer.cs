namespace Clock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowWeekDay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCB = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCB_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCB_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCB_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmCB_Default = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCF_BlueViolet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCF_SeaShell = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCF_Snow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmCF_Default = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmShowControls = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.ContextMenuStrip = this.contextMenu;
            this.labelTime.Name = "labelTime";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTopmost,
            this.cmShowControls,
            this.toolStripSeparator1,
            this.cmShowDate,
            this.cmShowWeekDay,
            this.toolStripSeparator5,
            this.cmColor,
            this.toolStripSeparator2,
            this.cmExit});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // cmTopmost
            // 
            this.cmTopmost.CheckOnClick = true;
            this.cmTopmost.Name = "cmTopmost";
            resources.ApplyResources(this.cmTopmost, "cmTopmost");
            this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // cmShowDate
            // 
            this.cmShowDate.CheckOnClick = true;
            this.cmShowDate.Name = "cmShowDate";
            resources.ApplyResources(this.cmShowDate, "cmShowDate");
            this.cmShowDate.CheckedChanged += new System.EventHandler(this.cmShowDate_CheckedChanged);
            // 
            // cmShowWeekDay
            // 
            this.cmShowWeekDay.CheckOnClick = true;
            this.cmShowWeekDay.Name = "cmShowWeekDay";
            resources.ApplyResources(this.cmShowWeekDay, "cmShowWeekDay");
            this.cmShowWeekDay.CheckedChanged += new System.EventHandler(this.cmShowWeekDay_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // cmColor
            // 
            this.cmColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmCB,
            this.foregroundColorToolStripMenuItem});
            this.cmColor.Name = "cmColor";
            resources.ApplyResources(this.cmColor, "cmColor");
            // 
            // cmCB
            // 
            this.cmCB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmCB_Red,
            this.cmCB_Green,
            this.cmCB_Blue,
            this.toolStripSeparator3,
            this.cmCB_Default});
            this.cmCB.Name = "cmCB";
            resources.ApplyResources(this.cmCB, "cmCB");
            // 
            // cmCB_Red
            // 
            this.cmCB_Red.Name = "cmCB_Red";
            resources.ApplyResources(this.cmCB_Red, "cmCB_Red");
            this.cmCB_Red.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // cmCB_Green
            // 
            this.cmCB_Green.Name = "cmCB_Green";
            resources.ApplyResources(this.cmCB_Green, "cmCB_Green");
            this.cmCB_Green.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // cmCB_Blue
            // 
            this.cmCB_Blue.Name = "cmCB_Blue";
            resources.ApplyResources(this.cmCB_Blue, "cmCB_Blue");
            this.cmCB_Blue.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // cmCB_Default
            // 
            this.cmCB_Default.Name = "cmCB_Default";
            resources.ApplyResources(this.cmCB_Default, "cmCB_Default");
            this.cmCB_Default.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // foregroundColorToolStripMenuItem
            // 
            this.foregroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmCF_BlueViolet,
            this.cmCF_SeaShell,
            this.cmCF_Snow,
            this.toolStripSeparator4,
            this.cmCF_Default});
            this.foregroundColorToolStripMenuItem.Name = "foregroundColorToolStripMenuItem";
            resources.ApplyResources(this.foregroundColorToolStripMenuItem, "foregroundColorToolStripMenuItem");
            // 
            // cmCF_BlueViolet
            // 
            this.cmCF_BlueViolet.Name = "cmCF_BlueViolet";
            resources.ApplyResources(this.cmCF_BlueViolet, "cmCF_BlueViolet");
            this.cmCF_BlueViolet.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // cmCF_SeaShell
            // 
            this.cmCF_SeaShell.Name = "cmCF_SeaShell";
            resources.ApplyResources(this.cmCF_SeaShell, "cmCF_SeaShell");
            this.cmCF_SeaShell.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // cmCF_Snow
            // 
            this.cmCF_Snow.Name = "cmCF_Snow";
            resources.ApplyResources(this.cmCF_Snow, "cmCF_Snow");
            this.cmCF_Snow.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // cmCF_Default
            // 
            this.cmCF_Default.Name = "cmCF_Default";
            resources.ApplyResources(this.cmCF_Default, "cmCF_Default");
            this.cmCF_Default.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // cmExit
            // 
            this.cmExit.Name = "cmExit";
            resources.ApplyResources(this.cmExit, "cmExit");
            this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cbShowDate
            // 
            resources.ApplyResources(this.cbShowDate, "cbShowDate");
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // btnHideControls
            // 
            resources.ApplyResources(this.btnHideControls, "btnHideControls");
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // cbShowWeekDay
            // 
            resources.ApplyResources(this.cbShowWeekDay, "cbShowWeekDay");
            this.cbShowWeekDay.Name = "cbShowWeekDay";
            this.cbShowWeekDay.UseVisualStyleBackColor = true;
            this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.cbShowWeekDay_CheckedChanged);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // cmShowControls
            // 
            this.cmShowControls.CheckOnClick = true;
            this.cmShowControls.Name = "cmShowControls";
            resources.ApplyResources(this.cmShowControls, "cmShowControls");
            this.cmShowControls.CheckedChanged += new System.EventHandler(this.cmShowControls_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbShowWeekDay);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmTopmost;
        private System.Windows.Forms.ToolStripMenuItem cmShowDate;
        private System.Windows.Forms.ToolStripMenuItem cmShowWeekDay;
        private System.Windows.Forms.ToolStripMenuItem cmExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmColor;
        private System.Windows.Forms.ToolStripMenuItem cmCB;
        private System.Windows.Forms.ToolStripMenuItem cmCB_Red;
        private System.Windows.Forms.ToolStripMenuItem cmCB_Green;
        private System.Windows.Forms.ToolStripMenuItem cmCB_Blue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmCB_Default;
        private System.Windows.Forms.ToolStripMenuItem foregroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmCF_BlueViolet;
        private System.Windows.Forms.ToolStripMenuItem cmCF_Snow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmCF_Default;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmCF_SeaShell;
        private System.Windows.Forms.ToolStripMenuItem cmShowControls;
    }
}

