
namespace Vizsgaremek_Csharp
{
    partial class Form_Foablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Foablak));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_cikkszam = new System.Windows.Forms.TextBox();
            this.textBox_megnevezes = new System.Windows.Forms.TextBox();
            this.numericUpDown_darab = new System.Windows.Forms.NumericUpDown();
            this.textBox_allapot = new System.Windows.Forms.TextBox();
            this.textBox_leiras = new System.Windows.Forms.TextBox();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_afa = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_darab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_afa)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(953, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cikkszám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Megnevezés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Darab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Állapot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Leirás";
            // 
            // textBox_cikkszam
            // 
            this.textBox_cikkszam.Location = new System.Drawing.Point(20, 203);
            this.textBox_cikkszam.Name = "textBox_cikkszam";
            this.textBox_cikkszam.Size = new System.Drawing.Size(83, 20);
            this.textBox_cikkszam.TabIndex = 6;
            // 
            // textBox_megnevezes
            // 
            this.textBox_megnevezes.Location = new System.Drawing.Point(109, 203);
            this.textBox_megnevezes.Name = "textBox_megnevezes";
            this.textBox_megnevezes.Size = new System.Drawing.Size(157, 20);
            this.textBox_megnevezes.TabIndex = 7;
            // 
            // numericUpDown_darab
            // 
            this.numericUpDown_darab.Location = new System.Drawing.Point(272, 203);
            this.numericUpDown_darab.Name = "numericUpDown_darab";
            this.numericUpDown_darab.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown_darab.TabIndex = 8;
            // 
            // textBox_allapot
            // 
            this.textBox_allapot.Location = new System.Drawing.Point(355, 203);
            this.textBox_allapot.Name = "textBox_allapot";
            this.textBox_allapot.Size = new System.Drawing.Size(127, 20);
            this.textBox_allapot.TabIndex = 9;
            // 
            // textBox_leiras
            // 
            this.textBox_leiras.Location = new System.Drawing.Point(492, 203);
            this.textBox_leiras.Name = "textBox_leiras";
            this.textBox_leiras.Size = new System.Drawing.Size(168, 20);
            this.textBox_leiras.TabIndex = 10;
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(666, 203);
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown_ar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ár";
            // 
            // numericUpDown_afa
            // 
            this.numericUpDown_afa.Location = new System.Drawing.Point(770, 203);
            this.numericUpDown_afa.Name = "numericUpDown_afa";
            this.numericUpDown_afa.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_afa.TabIndex = 13;
            this.numericUpDown_afa.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(781, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ÁFA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Árut felvesz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(840, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Árut töröl";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(840, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Árut modosit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form_Foablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 630);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_afa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_ar);
            this.Controls.Add(this.textBox_leiras);
            this.Controls.Add(this.textBox_allapot);
            this.Controls.Add(this.numericUpDown_darab);
            this.Controls.Add(this.textBox_megnevezes);
            this.Controls.Add(this.textBox_cikkszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Foablak";
            this.Text = "Vizsgaremek";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_darab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_afa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cikkszam;
        private System.Windows.Forms.TextBox textBox_megnevezes;
        private System.Windows.Forms.NumericUpDown numericUpDown_darab;
        private System.Windows.Forms.TextBox textBox_allapot;
        private System.Windows.Forms.TextBox textBox_leiras;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_afa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListBox listBox1;
    }
}