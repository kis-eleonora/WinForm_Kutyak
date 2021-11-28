using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Kutyak
{
    class Kutya
    {
        string nev;
        string fajta;
        double suly;
        string datum;
        public string Nev { get => nev; set => nev = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public double Suly { get => suly; set => suly = value; }
        public string Datum { get => datum; set => datum = value; }

        public Kutya(string nev, string fajta, int suly, string datum)
        {
            Nev = nev;
            Fajta = fajta;
            Suly = suly;
            Datum = datum;
        }

        public override string ToString()
        {
            return nev;
        }

    }
}
