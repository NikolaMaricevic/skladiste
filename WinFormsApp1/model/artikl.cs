using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1

{
    internal class artikl
    {

        public string ISBN { get; set; }
        public string naziv { get; set; }
        public string proizvodac { get; set; }
        public string kategorija { get; set; }
        public int broj_dostupnih { get; set; }



        public int CompareTo(object obj)
        {
            int rez = proizvodac.CompareTo(((artikl)obj).proizvodac);

            if (rez == 0) { rez = naziv.CompareTo(((artikl)obj).naziv); }
            return rez;
        }

        public override string ToString() => ISBN + " " + naziv + ", " + proizvodac + ", " + kategorija + ", " + broj_dostupnih;
    }
}

