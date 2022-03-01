using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vizsgaremek_Csharp
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Belepes_Click(object sender, EventArgs e)
        {
            string nev = textBox_Belepesnev.Text;
            string jelszo = textBox_Belepesjelszo.Text;

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "vizsgaremek";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ToString());
            sql = connection.CreateCommand();

            string belepes = "SELECT * FROM `dolgozo` WHERE  felhasznalonev = `" + nev.Trim() + "` AND jelszo = `" + jelszo.Trim()+ "`";


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
