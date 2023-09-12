using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Za6
{
    
   public class Student:Osoba
    {
        string indeks;

        public string Indeks { get => indeks; set => indeks = value; }

        public Student(string indeks)
        {
            this.indeks = indeks;
        }

        public Student(string ime, string prezime, int godine, string indeks) : base(ime, prezime, godine)
        {
            this.indeks = indeks;
        }

        public Student() : base()
        {
            this.Ime = "";
            this.Prezime = "";
            this.Godine = 0;
            this.indeks = "";
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Godine + " " + indeks;
        }
    }
}
