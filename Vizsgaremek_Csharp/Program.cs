using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizsgaremek_Csharp
{
    static class Program
    {
        public static Form1 form1 = null;
        public static Form_Foablak form_Foablak = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            form_Foablak = new Form_Foablak();
            Application.Run(form1);
        }
    }
}
