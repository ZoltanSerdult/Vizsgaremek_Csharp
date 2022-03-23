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
            label_afamutat.Text = ($"A jelenlegi \náfa érték {afaertek}%");
        }

        private void button_afaBeallit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("afa.txt");
            sw.Write(numericUpDown_afa.Value);
            sw.Close();
            label_afamutat.Text = "A jelenlegi \náfa érték " + numericUpDown_afa.Value.ToString() +"%";
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
                        Termek uj = new Termek(/* dr.GetInt32("termek_id" ), */
                            dr.GetString("nev"),
                            dr.GetInt32("ar"),                           
                            dr.GetInt32("keszlet"),
                            dr.GetString("foglalat"),
                            dr.GetString("forma"),
                            dr.GetInt32("teljesitmeny"),
                            dr.GetInt32("szinhomerseklet"),
                            dr.GetString("termekkod"),
                            dr.GetInt32("ean"),
                            dr.GetString("allapot"),
                            dr.GetString("leiras"),
                            dr.GetInt32("elerheto"),
                            dr.GetInt32("akcio"),
                            dr.GetString("marka"));
                        listBox_Termek.Items.Add(uj);
                    }
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            

        }

        private void button_felvesz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_megnevezes.Text))
            {
                MessageBox.Show("Nincs kitöltve a megnevezés mezö", "Hiányzó Adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_marka.Text))
            {
                MessageBox.Show("Nincs kitöltve a márka mezö", "Hiányzó Adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_termekkod.Text))
            {
                MessageBox.Show("Nincs kitöltve a Termék kód mezö", "Hiányzó Adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_ean.Text))
            {
                MessageBox.Show("Nincs kitöltve a EAN kód mezö", "Hiányzó Adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_allapot.Text))
            {
                MessageBox.Show("Nincs kitöltve a Állapot", "Hiányzó Adat");
                return;
            }
            if (string.IsNullOrEmpty(textBox_leiras.Text))
            {
                MessageBox.Show("Nincs kitöltve a Leirás mezö", "Hiányzó Adat");
                return;
            }
            
            sql.CommandText = "INSERT INTO `termek` (`nev`, `ar`, `keszlet`, `foglalat`, `forma`, `teljesitmeny`, `szinhomerseklet`, `termekkod`, `ean`, `allapot`, `leiras`, `elerheto`, `akcio`, `marka`) VALUES (@nev, @ar, @keszlet, @foglalat, @forma, @teljesitmeny, @szinhomerseklet, @termekkod, @ean, @allapot, @leiras, @akcio, @marka);";

            
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

            Termekmegjelenit();
        }

        private void listBox_Termek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termek kivalaszt = (Termek)listBox_Termek.SelectedItem;
            textBox_megnevezes.Text = kivalaszt.Nev.ToString();
            numericUpDown_darab.Value = kivalaszt.Keszlet;
            numericUpDown_ar.Value = kivalaszt.Ar;
            textBox_marka.Text = kivalaszt.Marka.ToString();
            numericUpDown_akcio.Value = kivalaszt.Akcio;
            textBox_termekkod.Text = kivalaszt.Termekkod.ToString();
            textBox_ean.Text = kivalaszt.Ean.ToString();
            textBox_allapot.Text = kivalaszt.Allapot.ToString();
            textBox_leiras.Text = kivalaszt.Leiras.ToString();
            textBox_foglalat.Text = kivalaszt.Foglalat.ToString();
            textBox_forma.Text = kivalaszt.Forma.ToString();
            numericUpDown_teljesitmeny.Value = kivalaszt.Teljesimeny;
            numericUpDown_szinho.Value = kivalaszt.Szinho;
        }
    }
}
