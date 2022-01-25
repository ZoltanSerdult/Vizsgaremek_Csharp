using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizsgaremek_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Belepes_Click(object sender, EventArgs e)
        {
            button_Programindito.Visible = true;
            textBox_Belepesnev.Visible = false;
            label2.Visible = false;
            textBox_Belepesjelszo.Visible = false;
            button_Belepes.Visible = false;
            label1.Text = "Bejentkezve";
        }

        private void button_Programindito_Click(object sender, EventArgs e)
        {
            Program.form_Foablak.ShowDialog();
        }
    }
}
