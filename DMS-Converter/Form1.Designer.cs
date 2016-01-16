namespace DMS_Converter
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.gbDMS = new System.Windows.Forms.GroupBox();
            this.gbDecimal = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.labelDeg.Location = new System.Drawing.Point(116, 19);
            this.labelDeg.Name = "labelDeg";
            this.labelDeg.Size = new System.Drawing.Size(47, 13);
            this.labelDeg.TabIndex = 0;
            this.labelDeg.Text = "Degrees";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(238, 19);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(44, 13);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "Minutes";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(364, 19);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(49, 13);
            this.labelSec.TabIndex = 2;
            this.labelSec.Text = "Seconds";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(336, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(89, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
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
            this.gbDMS.Controls.Add(this.textBox2);
            this.gbDMS.Controls.Add(this.labelLong);
            this.gbDMS.Controls.Add(this.labelDeg);
            this.gbDMS.Controls.Add(this.labelLat);
            this.gbDMS.Controls.Add(this.labelMin);
            this.gbDMS.Controls.Add(this.textBox4);
            this.gbDMS.Controls.Add(this.labelSec);
            this.gbDMS.Controls.Add(this.textBox5);
            this.gbDMS.Controls.Add(this.textBox1);
            this.gbDMS.Controls.Add(this.textBox6);
            this.gbDMS.Controls.Add(this.textBox3);
            this.gbDMS.Location = new System.Drawing.Point(12, 12);
            this.gbDMS.Name = "gbDMS";
            this.gbDMS.Size = new System.Drawing.Size(448, 105);
            this.gbDMS.TabIndex = 11;
            this.gbDMS.TabStop = false;
            this.gbDMS.Text = "DMS";
            // 
            // gbDecimal
            // 
            this.gbDecimal.Controls.Add(this.textBox8);
            this.gbDecimal.Controls.Add(this.textBox7);
            this.gbDecimal.Controls.Add(this.labelDecLong);
            this.gbDecimal.Controls.Add(this.labelDecLat);
            this.gbDecimal.Location = new System.Drawing.Point(12, 124);
            this.gbDecimal.Name = "gbDecimal";
            this.gbDecimal.Size = new System.Drawing.Size(448, 77);
            this.gbDecimal.TabIndex = 12;
            this.gbDecimal.TabStop = false;
            this.gbDecimal.Text = "Decimal";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(303, 35);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(133, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(89, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 20);
            this.textBox7.TabIndex = 2;
            // 
            // labelDecLong
            // 
            this.labelDecLong.AutoSize = true;
            this.labelDecLong.Location = new System.Drawing.Point(243, 38);
            this.labelDecLong.Name = "labelDecLong";
            this.labelDecLong.Size = new System.Drawing.Size(54, 13);
            this.labelDecLong.TabIndex = 1;
            this.labelDecLong.Text = "Longitude";
            // 
            // labelDecLat
            // 
            this.labelDecLat.AutoSize = true;
            this.labelDecLat.Location = new System.Drawing.Point(38, 38);
            this.labelDecLat.Name = "labelDecLat";
            this.labelDecLat.Size = new System.Drawing.Size(45, 13);
            this.labelDecLat.TabIndex = 0;
            this.labelDecLat.Text = "Latitude";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(348, 210);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            // 
            // rbDMS
            // 
            this.rbDMS.AutoSize = true;
            this.rbDMS.Location = new System.Drawing.Point(30, 213);
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
            this.rbDecimal.Location = new System.Drawing.Point(170, 213);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(124, 17);
            this.rbDecimal.TabIndex = 15;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.Text = "Convert from decimal";
            this.rbDecimal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(475, 251);
            this.Controls.Add(this.rbDecimal);
            this.Controls.Add(this.rbDMS);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbDecimal);
            this.Controls.Add(this.gbDMS);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.GroupBox gbDMS;
        private System.Windows.Forms.GroupBox gbDecimal;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelDecLong;
        private System.Windows.Forms.Label labelDecLat;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbDMS;
        private System.Windows.Forms.RadioButton rbDecimal;
    }
}

