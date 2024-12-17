namespace Clock
{
    partial class ChooseFontForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFontForm));
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.labelChooseFont = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(18, 70);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(329, 21);
            this.cbFonts.TabIndex = 0;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(355, 71);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(72, 20);
            this.nudFontSize.TabIndex = 1;
            this.nudFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // labelChooseFont
            // 
            this.labelChooseFont.AutoSize = true;
            this.labelChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFont.Location = new System.Drawing.Point(18, 35);
            this.labelChooseFont.Name = "labelChooseFont";
            this.labelChooseFont.Size = new System.Drawing.Size(134, 25);
            this.labelChooseFont.TabIndex = 2;
            this.labelChooseFont.Text = "Choose font:";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFontSize.Location = new System.Drawing.Point(355, 35);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(106, 25);
            this.labelFontSize.TabIndex = 3;
            this.labelFontSize.Text = "Font size:";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.Location = new System.Drawing.Point(18, 118);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(85, 24);
            this.labelExample.TabIndex = 4;
            this.labelExample.Text = "Example";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(293, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(374, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChooseFontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 328);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.labelChooseFont);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.cbFonts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseFontForm";
            this.Text = "ChooseFont:";
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label labelChooseFont;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}