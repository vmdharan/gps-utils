namespace DMS_Converter
{
    partial class DMSConverter
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
            this.labelDeg = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.tbLatDeg = new System.Windows.Forms.TextBox();
            this.tbLatMin = new System.Windows.Forms.TextBox();
            this.tbLatSec = new System.Windows.Forms.TextBox();
            this.tbLongSec = new System.Windows.Forms.TextBox();
            this.tbLongMin = new System.Windows.Forms.TextBox();
            this.tbLongDeg = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.gbDMS = new System.Windows.Forms.GroupBox();
            this.gbDecimal = new System.Windows.Forms.GroupBox();
            this.tbLongDec = new System.Windows.Forms.TextBox();
            this.tbLatDec = new System.Windows.Forms.TextBox();
            this.labelDecLong = new System.Windows.Forms.Label();
            this.labelDecLat = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbDMS = new System.Windows.Forms.RadioButton();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.gbDMS.SuspendLayout();
            this.gbDecimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDeg
            // 
            this.labelDeg.AutoSize = true;
            this.labelDeg.Location = new System.Drawing.Point(86, 30);
            this.labelDeg.Name = "labelDeg";
            this.labelDeg.Size = new System.Drawing.Size(47, 13);
            this.labelDeg.TabIndex = 0;
            this.labelDeg.Text = "Degrees";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(145, 30);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(44, 13);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "Minutes";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(218, 30);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(49, 13);
            this.labelSec.TabIndex = 2;
            this.labelSec.Text = "Seconds";
            // 
            // tbLatDeg
            // 
            this.tbLatDeg.Location = new System.Drawing.Point(89, 46);
            this.tbLatDeg.Name = "tbLatDeg";
            this.tbLatDeg.Size = new System.Drawing.Size(41, 20);
            this.tbLatDeg.TabIndex = 3;
            // 
            // tbLatMin
            // 
            this.tbLatMin.Location = new System.Drawing.Point(148, 46);
            this.tbLatMin.Name = "tbLatMin";
            this.tbLatMin.Size = new System.Drawing.Size(41, 20);
            this.tbLatMin.TabIndex = 4;
            // 
            // tbLatSec
            // 
            this.tbLatSec.Location = new System.Drawing.Point(208, 46);
            this.tbLatSec.Name = "tbLatSec";
            this.tbLatSec.Size = new System.Drawing.Size(74, 20);
            this.tbLatSec.TabIndex = 5;
            // 
            // tbLongSec
            // 
            this.tbLongSec.Location = new System.Drawing.Point(208, 72);
            this.tbLongSec.Name = "tbLongSec";
            this.tbLongSec.Size = new System.Drawing.Size(74, 20);
            this.tbLongSec.TabIndex = 8;
            // 
            // tbLongMin
            // 
            this.tbLongMin.Location = new System.Drawing.Point(148, 72);
            this.tbLongMin.Name = "tbLongMin";
            this.tbLongMin.Size = new System.Drawing.Size(41, 20);
            this.tbLongMin.TabIndex = 7;
            // 
            // tbLongDeg
            // 
            this.tbLongDeg.Location = new System.Drawing.Point(89, 72);
            this.tbLongDeg.Name = "tbLongDeg";
            this.tbLongDeg.Size = new System.Drawing.Size(41, 20);
            this.tbLongDeg.TabIndex = 6;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(24, 49);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(45, 13);
            this.labelLat.TabIndex = 9;
            this.labelLat.Text = "Latitude";
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Location = new System.Drawing.Point(15, 75);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(54, 13);
            this.labelLong.TabIndex = 10;
            this.labelLong.Text = "Longitude";
            // 
            // gbDMS
            // 
            this.gbDMS.Controls.Add(this.tbLatMin);
            this.gbDMS.Controls.Add(this.labelLong);
            this.gbDMS.Controls.Add(this.labelDeg);
            this.gbDMS.Controls.Add(this.labelLat);
            this.gbDMS.Controls.Add(this.tbLongMin);
            this.gbDMS.Controls.Add(this.labelMin);
            this.gbDMS.Controls.Add(this.tbLatSec);
            this.gbDMS.Controls.Add(this.tbLongSec);
            this.gbDMS.Controls.Add(this.labelSec);
            this.gbDMS.Controls.Add(this.tbLatDeg);
            this.gbDMS.Controls.Add(this.tbLongDeg);
            this.gbDMS.Location = new System.Drawing.Point(12, 12);
            this.gbDMS.Name = "gbDMS";
            this.gbDMS.Size = new System.Drawing.Size(314, 105);
            this.gbDMS.TabIndex = 11;
            this.gbDMS.TabStop = false;
            this.gbDMS.Text = "DMS";
            // 
            // gbDecimal
            // 
            this.gbDecimal.Controls.Add(this.tbLongDec);
            this.gbDecimal.Controls.Add(this.tbLatDec);
            this.gbDecimal.Controls.Add(this.labelDecLong);
            this.gbDecimal.Controls.Add(this.labelDecLat);
            this.gbDecimal.Location = new System.Drawing.Point(12, 124);
            this.gbDecimal.Name = "gbDecimal";
            this.gbDecimal.Size = new System.Drawing.Size(314, 77);
            this.gbDecimal.TabIndex = 12;
            this.gbDecimal.TabStop = false;
            this.gbDecimal.Text = "Decimal";
            // 
            // tbLongDec
            // 
            this.tbLongDec.Location = new System.Drawing.Point(171, 38);
            this.tbLongDec.Name = "tbLongDec";
            this.tbLongDec.Size = new System.Drawing.Size(111, 20);
            this.tbLongDec.TabIndex = 3;
            // 
            // tbLatDec
            // 
            this.tbLatDec.Location = new System.Drawing.Point(31, 38);
            this.tbLatDec.Name = "tbLatDec";
            this.tbLatDec.Size = new System.Drawing.Size(111, 20);
            this.tbLatDec.TabIndex = 2;
            // 
            // labelDecLong
            // 
            this.labelDecLong.AutoSize = true;
            this.labelDecLong.Location = new System.Drawing.Point(196, 22);
            this.labelDecLong.Name = "labelDecLong";
            this.labelDecLong.Size = new System.Drawing.Size(54, 13);
            this.labelDecLong.TabIndex = 1;
            this.labelDecLong.Text = "Longitude";
            // 
            // labelDecLat
            // 
            this.labelDecLat.AutoSize = true;
            this.labelDecLat.Location = new System.Drawing.Point(67, 22);
            this.labelDecLat.Name = "labelDecLat";
            this.labelDecLat.Size = new System.Drawing.Size(45, 13);
            this.labelDecLat.TabIndex = 0;
            this.labelDecLat.Text = "Latitude";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(204, 216);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbDMS
            // 
            this.rbDMS.AutoSize = true;
            this.rbDMS.Location = new System.Drawing.Point(30, 207);
            this.rbDMS.Name = "rbDMS";
            this.rbDMS.Size = new System.Drawing.Size(112, 17);
            this.rbDMS.TabIndex = 14;
            this.rbDMS.TabStop = true;
            this.rbDMS.Text = "Convert from DMS";
            this.rbDMS.UseVisualStyleBackColor = true;
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.Location = new System.Drawing.Point(30, 230);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(124, 17);
            this.rbDecimal.TabIndex = 15;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.Text = "Convert from decimal";
            this.rbDecimal.UseVisualStyleBackColor = true;
            // 
            // DMSConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(339, 256);
            this.Controls.Add(this.rbDecimal);
            this.Controls.Add(this.rbDMS);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbDecimal);
            this.Controls.Add(this.gbDMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DMSConverter";
            this.Text = "DMS Converter";
            this.gbDMS.ResumeLayout(false);
            this.gbDMS.PerformLayout();
            this.gbDecimal.ResumeLayout(false);
            this.gbDecimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeg;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.TextBox tbLatDeg;
        private System.Windows.Forms.TextBox tbLatMin;
        private System.Windows.Forms.TextBox tbLatSec;
        private System.Windows.Forms.TextBox tbLongSec;
        private System.Windows.Forms.TextBox tbLongMin;
        private System.Windows.Forms.TextBox tbLongDeg;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.GroupBox gbDMS;
        private System.Windows.Forms.GroupBox gbDecimal;
        private System.Windows.Forms.TextBox tbLatDec;
        private System.Windows.Forms.Label labelDecLong;
        private System.Windows.Forms.Label labelDecLat;
        private System.Windows.Forms.TextBox tbLongDec;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbDMS;
        private System.Windows.Forms.RadioButton rbDecimal;
    }
}

