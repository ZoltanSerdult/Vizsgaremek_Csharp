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
using System.IO;

namespace Vizsgaremek_Csharp
{
    public partial class Form_Foablak : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Form_Foablak()
        {
            InitializeComponent();
        }


        private void Form_Foablak_Load(object sender, EventArgs e)
        {
            
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "localhost";
                sb.UserID = "root";
                sb.Password = "";
                sb.Database = "vizsgaremek";
                sb.CharacterSet = "utf8";
                connection = new MySqlConnection(sb.ToString());
                sql = connection.CreateCommand();
            
            Termekmegjelenit();

            
            StreamReader sr = new StreamReader("afa.txt", Encoding.Default);
                string afaertek = sr.ReadLine();
                sr.Close();
            numericUpDown_afa.Value = Convert.ToInt32(afaertek);
            label_afamutat.Text = (afaertek);
        }

        private void button_afaBeallit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("afa.txt");
            sw.Write(numericUpDown_afa.Value);
            sw.Close();
        }

        private void Termekmegjelenit()
        {
            listBox_Termek.Items.Clear();
            try
            {
                connection.Open();
                sql.CommandText = "SELECT `termek_id`, `nev`, `ar`, `keszlet`, `foglalat`, `forma`, `teljesitmeny`, `szinhomerseklet`, `termekkod`, `ean`, `allapot`, `leiras`, `elerheto`, `akcio`, `marka` FROM `termek` WHERE 1; ";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Termek uj = new Termek(dr.GetInt32("termek_id"),
                            dr.GetString("nev"),
                            dr.GetInt32("ar"),                           
                            dr.GetInt32("keszlet"),
                            dr.GetString("foglalat"),
                            dr.GetString("forma"),
                            dr.GetInt32("teljesitmeny"),
                            dr.GetInt32("szinhomerseklet"),
                            dr.GetString("termekkod"),
                            dr.GetInt32("ean"),
                            dr.GetInt32("allapot"),
                            dr.GetString("leiras"),
                            dr.GetInt32("elerheto"),
                            dr.GetInt32("akcio"),
                            dr.GetString("marka"));
                        listBox_Termek.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void button_felvesz_Click(object sender, EventArgs e)
        {
            sql.CommandText = "INSERT INTO `termek` (`termek_id`, `nev`, `ar`, `keszlet`, `foglalat`, `forma`, `teljesitmeny`, `szinhomerseklet`, `termekkod`, `ean`, `allapot`, `leiras`, `elerheto`, `akcio`, `marka`) VALUES (NULL, @termek_id, @nev, @ar, @keszlet, @foglalat, @forma, @teljesitmeny, @szinhomerseklet, @termekkod, @ean, @allapot, @leiras, @akcio, @marka);";
            sql.Parameters.AddWithValue("@termek_id", textBox_termekkod.Text);
            sql.Parameters.AddWithValue("@nev", textBox_megnevezes.Text);
            sql.Parameters.AddWithValue("@ar",numericUpDown_ar.Value);
            sql.Parameters.AddWithValue("@keszlet",numericUpDown_darab.Value);
            sql.Parameters.AddWithValue("@foglalat",textBox_foglalat.Text);
            sql.Parameters.AddWithValue("@forma",textBox_forma.Text);
            sql.Parameters.AddWithValue("@teljesitmany",numericUpDown_teljesitmeny.Value);
            sql.Parameters.AddWithValue("@szinhomerseklet",numericUpDown_szinho.Value);
            sql.Parameters.AddWithValue("@termekkod",textBox_termekkod.Text);
            sql.Parameters.AddWithValue("@ean",textBox_ean.Text);
            sql.Parameters.AddWithValue("@allapot",textBox_allapot.Text);
            sql.Parameters.AddWithValue("@leiras",textBox_leiras.Text);
            sql.Parameters.AddWithValue("@akcio",numericUpDown_akcio.Value);
            sql.Parameters.AddWithValue("@marka",textBox_marka.Text);
            try
            {
                connection.Open();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
