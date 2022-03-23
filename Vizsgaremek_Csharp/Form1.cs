using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Vizsgaremek_Csharp
{
    public partial class Form1 : Form
    {
        MySqlConnection Con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=vizsgaremek;User Id=root;password=''");
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Belepes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Belepesnev.Text))
            {
                MessageBox.Show("Hiányzó név", "Hiányzó adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Belepesjelszo.Text))
            {
                MessageBox.Show("Hiányzó jelszó", "Hiányzó adat");
                return;
            }

            string input_nev = textBox_Belepesnev.Text;
            string input_jelszo = textBox_Belepesjelszo.Text;
            
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";                                    
            sb.Database = "vizsgaremek";
            sb.CharacterSet = "utf8";
            MySqlConnection con = new MySqlConnection(sb.ToString());


            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT `felhasznalonev`,`jelszo` FROM `dolgozo`;";
                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string felh = dr.GetString("felhasznalonev");
                        string jelszo = dr.GetString("jelszo");

                        if (input_nev == felh && input_jelszo == jelszo)
                        {
                            button_Programindito.Visible = true;
                            textBox_Belepesnev.Visible = false;
                            label2.Visible = false;
                            textBox_Belepesjelszo.Visible = false;
                            button_Belepes.Visible = false;
                            label1.Text = "Bejentkezve";
                        }
                        else
                        {
                            MessageBox.Show("Rossz adatot adott meg", "FIGYELMEZTETÉS",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            textBox_Belepesnev.Text = "";
                            textBox_Belepesjelszo.Text = "";
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Hiba \nKeresse fel a rendszergazdát \nA jelenlegi hiba: \n \n{ex}", "HIBA");
            }


            /*
            button_Programindito.Visible = true;
            textBox_Belepesnev.Visible = false;
            label2.Visible = false;
            textBox_Belepesjelszo.Visible = false;
            button_Belepes.Visible = false;
            label1.Text = "Bejentkezve";
            */


        }

        private void button_Programindito_Click(object sender, EventArgs e)
        {
            Program.form_Foablak.ShowDialog();
            Program.form1.Close();
        }
    }
}
