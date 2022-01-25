
namespace Vizsgaremek_Csharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Belepesjelszo = new System.Windows.Forms.TextBox();
            this.textBox_Belepesnev = new System.Windows.Forms.TextBox();
            this.button_Belepes = new System.Windows.Forms.Button();
            this.button_Programindito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(144, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó";
            // 
            // textBox_Belepesjelszo
            // 
            this.textBox_Belepesjelszo.Location = new System.Drawing.Point(77, 95);
            this.textBox_Belepesjelszo.Name = "textBox_Belepesjelszo";
            this.textBox_Belepesjelszo.Size = new System.Drawing.Size(200, 20);
            this.textBox_Belepesjelszo.TabIndex = 3;
            // 
            // textBox_Belepesnev
            // 
            this.textBox_Belepesnev.Location = new System.Drawing.Point(77, 36);
            this.textBox_Belepesnev.Name = "textBox_Belepesnev";
            this.textBox_Belepesnev.Size = new System.Drawing.Size(200, 20);
            this.textBox_Belepesnev.TabIndex = 4;
            // 
            // button_Belepes
            // 
            this.button_Belepes.Location = new System.Drawing.Point(98, 121);
            this.button_Belepes.Name = "button_Belepes";
            this.button_Belepes.Size = new System.Drawing.Size(163, 30);
            this.button_Belepes.TabIndex = 5;
            this.button_Belepes.Text = "BEJELENKEZÉS";
            this.button_Belepes.UseVisualStyleBackColor = true;
            this.button_Belepes.Click += new System.EventHandler(this.button_Belepes_Click);
            // 
            // button_Programindito
            // 
            this.button_Programindito.Location = new System.Drawing.Point(98, 157);
            this.button_Programindito.Name = "button_Programindito";
            this.button_Programindito.Size = new System.Drawing.Size(163, 33);
            this.button_Programindito.TabIndex = 6;
            this.button_Programindito.Text = "PROGRAM INDITÁSA";
            this.button_Programindito.UseVisualStyleBackColor = true;
            this.button_Programindito.Visible = false;
            this.button_Programindito.Click += new System.EventHandler(this.button_Programindito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 216);
            this.Controls.Add(this.button_Programindito);
            this.Controls.Add(this.button_Belepes);
            this.Controls.Add(this.textBox_Belepesnev);
            this.Controls.Add(this.textBox_Belepesjelszo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vizsgaremek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Belepesjelszo;
        private System.Windows.Forms.TextBox textBox_Belepesnev;
        private System.Windows.Forms.Button button_Belepes;
        private System.Windows.Forms.Button button_Programindito;
    }
}

