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
    public partial class Form_Foablak : Form
    {
        public Form_Foablak()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mybuilder = new MySqlConnectionStringBuilder();
            mybuilder.Server = "localhost";
            mybuilder.UserID = "root";
            mybuilder.Password = "";
            mybuilder.Database = "vizsgaremek";
            mybuilder.CharacterSet = "UTF8";
            MySqlConnection connection = new MySqlConnection(mybuilder.ToString());

        }
    }
}
