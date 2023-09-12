using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class main : Form
    {
        internal static registracija form2;
        internal static main form1;
        public main()
        {
            InitializeComponent();
            form1 = this;
        }

        string username = loginKorisnik.ime;
        string podaciOFilmu = "";
        int brojMesta = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //form2 = new registracija();
            //form2.Show();
        }
        public void enableB()
        {
            button3.Visible = true;
        }

        public void rezervacija()
        {
            string procitanFilm = "";
            foreach (var line in File.ReadAllLines("filmovi.txt"))
            {
                if (line.Contains("Naziv filma"))
                {
                    procitanFilm = line;
                }
            }
            string[] split = procitanFilm.Split(':');
            string two = split[1];
            int count = Convert.ToInt32(numericUpDown1.Value);
            brojMesta = count;
            MessageBox.Show("Rezervisali ste: " + "\n" + "Film: "+ two + "\n" +"Broj karti: " + vratiBrojMesta().ToString());



            StreamWriter a = new StreamWriter("rezervacije.txt", true);
            a.WriteLine("Ime korisnika: " + vratiImeKorisnika());
            a.WriteLine("Podaci o filmu: " + podaciOFilmu);
            //a.WriteLine("Admin: Ne");
            a.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rezervacija();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin forma3 = new admin();
            forma3.Show();


        }

        private void main_Load(object sender, EventArgs e)
        {
            if (File.Exists("sale.txt"))
            {
                azurirajSale();
            }
            if(loginKorisnik.jeAdmin == true)
            {
                enableB();
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void azurirajSale()
        {
            //StreamReader readfile = new StreamReader("sale.txt");

            //bool salaPostoji = false;
            //string line1 = readfile.ReadLine();
            //string line2 = readfile.ReadLine();
            //readfile.Close();
            foreach (var line in File.ReadAllLines("sale.txt"))
            {
                if (line.Contains("sala"))
                {
                    comboBox3.Items.Add(line.ToString());
                    comboBox3.Text = "Sale...";
                }
            }
               
        }

        public void azurirajRepertoar()
        {
            string procitanFilm = "";
            string procitanaDuzinaTrajanja = "";
            string cenaKarte = "";
            string datumProjekcije = "";
            string vremeProjekcije = "";
            string brojSedista = "";
            string brojSale = "";

                foreach (var line in File.ReadAllLines("filmovi.txt"))
            {       
               if (line.Contains("Naziv filma"))
                    {
                        procitanFilm = line;
                    }

               if (line.Contains("Duzina trajanja"))
                    {
                        procitanaDuzinaTrajanja = line;
                    }              
            }
            

            foreach (var line in File.ReadAllLines("projekcije.txt"))
            {

                if (line.Contains("Cena karte"))
                {
                    cenaKarte = line;
                }

                if (line.Contains("Datum projekcije"))
                {
                    datumProjekcije = line;
                }

                if(line.Contains("Vreme pocetka projekcije"))
                {
                    vremeProjekcije = line;
                }

            }

            foreach (var line in File.ReadAllLines("sale.txt"))
            {

                if (line.Contains("Broj sedista"))
                {
                    brojSedista = line;
                }

                if (line.Contains("Broj sale"))
                {
                    brojSale = line;
                }

            }
            string[] split = procitanaDuzinaTrajanja.Split(':');
            string two = split[1];

            string[] split2 = datumProjekcije.Split(':');
            string two2 = split2[1];

            string[] split3 = vremeProjekcije.Split('-');
            string two3 = split3[1];

            string[] split4 = brojSale.Split(':');
            string two4 = split4[1];

            string[] split5 = brojSedista.Split(':');
            string two5 = split5[1];

            string[] split6 = procitanFilm.Split(':');
            string two6 = split6[1];


            string merged = procitanFilm + " " + two + "min" + ", " +
                                cenaKarte.ToString() + ", " + "Datum i vreme:" +
                                two2 + " - " + two3 + ", " + two4 + ", " +
                                "Broj dostupnih sedista:" + two5 ;

            string zaRezervacju = two6 + " " + two + "min" + ", " +
                                vratiCenuKarte() + ", " + "Datum i vreme:" +
                                two2 + " - " + two3 + ", " + two4 + ", " + vratiBrojMesta().ToString();
            podaciOFilmu = zaRezervacju;
            listBox1.Items.Add(merged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            azurirajRepertoar();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (listBox1.SelectedIndex)
            {
                case 0:
                    var cena = vratiCenuKarte();
                    textBox1.Text = cena;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var cena = vratiCenuKarte();
            decimal cenaInt = Convert.ToInt32(cena);
            switch (numericUpDown1.Value)
            {
                
                case 1:            
                    textBox1.Text = ""+ cenaInt * 1;
                    break;
                case 2:
                   
                    textBox1.Text = "" + cenaInt * 2;
                    break;
                case 3:
                   
                    textBox1.Text = "" + cenaInt * 3;
                    break;
                case 4:
                    
                    textBox1.Text = "" + cenaInt * 4;
                    break;
                case 5:
                    
                    textBox1.Text = "" + cenaInt * 5;
                    break;
                case 6:
                    
                    textBox1.Text = "" + cenaInt * 6;
                    break;
                case 7:
                    
                    textBox1.Text = "" + cenaInt * 7;
                    break;
                case 8:
                    
                    textBox1.Text = "" + cenaInt * 8;
                    break;
            }
        }

        public string vratiCenuKarte()
        {
            string cenaKarte = "";

            foreach (var line in File.ReadAllLines("projekcije.txt"))
            {

                if (line.Contains("Cena karte"))
                {
                    cenaKarte = line;
                }
            }
            string[] split = cenaKarte.Split(':');
            string two = split[1];

            return two;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("", "Moje rezervacije");
        }

        public string vratiImeKorisnika()
        {
            string ime = "";
            ime = username;

            return ime;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int vratiBrojMesta()
        {
            int broj = 0;
            broj = brojMesta;
            return broj;

        }
    }
}
