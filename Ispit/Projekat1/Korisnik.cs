using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class Korisnik
    {
        string ime;
        string lozinka;
        Boolean admin;

        public Korisnik(string ime, string lozinka, bool admin)
        {
            this.ime = ime;
            this.lozinka = lozinka;
            this.admin = admin;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public bool Admin { get => admin; set => admin = value; }
    }
}
