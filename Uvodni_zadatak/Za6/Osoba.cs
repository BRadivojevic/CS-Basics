using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Za6
{
    
    public class Osoba
    {
        string ime, prezime;
        int godine;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godine { get => godine; set => godine = value; }

        public Osoba(string ime, string prezime, int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
        }

        public Osoba()
        {
            this.ime = "";
            this.prezime = "";
            this.godine = 0;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + godine;
        }

    }
}
