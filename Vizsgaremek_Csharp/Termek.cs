using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek_Csharp
{
    class Termek
    {
        readonly int termek_id;
        string nev;
        int ar;
        int keszlet;
        string foglalat;
        string forma;
        int teljesimeny;
        int szinho;
        string termekkod;
        int ean;
        int allapot;
        string leiras;
        int elerheto;
        int akcio;
        string marka;

        public int Termek_id => termek_id;

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Keszlet { get => keszlet; set => keszlet = value; }
        public string Foglalat { get => foglalat; set => foglalat = value; }
        public string Forma { get => forma; set => forma = value; }
        public int Teljesimeny { get => teljesimeny; set => teljesimeny = value; }
        public int Szinho { get => szinho; set => szinho = value; }
        public string Termekkod { get => termekkod; set => termekkod = value; }
        public int Ean { get => ean; set => ean = value; }
        public int Allapot { get => allapot; set => allapot = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Elerheto { get => elerheto; set => elerheto = value; }
        public int Akcio { get => akcio; set => akcio = value; }
        public string Marka { get => marka; set => marka = value; }

        public Termek(int termek_id, string nev, int ar, int keszlet, string foglalat, string forma, int teljesimeny, int szinho, string termekkod, int ean, int allapot, string leiras, int elerheto, int akcio, string marka)
        {
            this.termek_id = termek_id;
            Nev = nev;
            Ar = ar;
            Keszlet = keszlet;
            Foglalat = foglalat;
            Forma = forma;
            Teljesimeny = teljesimeny;
            Szinho = szinho;
            Termekkod = termekkod;
            Ean = ean;
            Allapot = allapot;
            Leiras = leiras;
            Elerheto = elerheto;
            Akcio = akcio;
            Marka = marka;
        }
    }
}
