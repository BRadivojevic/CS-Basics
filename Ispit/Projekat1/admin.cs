using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Projekat1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Dodavanje filmova";

            TextBox idFilm = new TextBox();
            idFilm.Text = "idFilm";
            idFilm.Name = "idFilm";
            idFilm.Top = 25;
            idFilm.Left = 25;
            frm.Controls.Add(idFilm);


            TextBox nazivFilm = new TextBox();
            nazivFilm.Text = "nazivFilm";
            nazivFilm.Name = "nazivFilm";
            nazivFilm.Top = idFilm.Top + 25;
            nazivFilm.Left = idFilm.Left;
            frm.Controls.Add(nazivFilm);

            TextBox zanrFilm = new TextBox();
            zanrFilm.Text = "zanrFilm";
            zanrFilm.Name = "zanrFilm";
            zanrFilm.Top = nazivFilm.Top + 25;
            zanrFilm.Left = nazivFilm.Left;
            frm.Controls.Add(zanrFilm);

            TextBox duzinaFilm = new TextBox();
            duzinaFilm.Text = "duzinaFilm";
            duzinaFilm.Name = "duzinaFilm";
            duzinaFilm.Top = zanrFilm.Top + 25;
            duzinaFilm.Left = zanrFilm.Left;
            frm.Controls.Add(duzinaFilm);

            TextBox granicaFilm = new TextBox();
            granicaFilm.Text = "granicaFilm";
            granicaFilm.Name = "granicaFilm";
            granicaFilm.Top = duzinaFilm.Top + 25;
            granicaFilm.Left = duzinaFilm.Left;
            frm.Controls.Add(granicaFilm);

            Button btn = new Button();
            btn.Text = "DODAJ";
            btn.Name = "btnDodajFilm";
            btn.Click += (s, f) => 
            {
                StreamWriter a = new StreamWriter("filmovi.txt", true);
                a.WriteLine("ID Filma: " + idFilm.Text.ToString());
                a.WriteLine("Naziv filma: " + nazivFilm.Text.ToString());
                a.WriteLine("Zanr filma: " + zanrFilm.Text.ToString());
                a.WriteLine("Duzina trajanja: " + duzinaFilm.Text.ToString());
                a.WriteLine("Starosna granica: " + granicaFilm.Text.ToString());
                a.WriteLine(Environment.NewLine);
                a.Close();
                MessageBox.Show("Uspesno ste dodali film!");
                frm.Close(); 
            };
            btn.Location = new System.Drawing.Point(200, 200);
            frm.Controls.Add(btn);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Kupci";

            TextBox idKupca = new TextBox();
            idKupca.Text = "idKupca";
            idKupca.Name = "idKupca";
            idKupca.Top = 25;
            idKupca.Left = 25;
            frm.Controls.Add(idKupca);


            TextBox imeKupca = new TextBox();
            imeKupca.Text = "imeKupca";
            imeKupca.Name = "imeKupca";
            imeKupca.Top = idKupca.Top + 25;
            imeKupca.Left = idKupca.Left;
            frm.Controls.Add(imeKupca);

            TextBox prezimeKupca = new TextBox();
            prezimeKupca.Text = "prezimeKupca";
            prezimeKupca.Name = "prezimeKupca";
            prezimeKupca.Top = imeKupca.Top + 25;
            prezimeKupca.Left = imeKupca.Left;
            frm.Controls.Add(prezimeKupca);

            TextBox datumRodjenjaKupca = new TextBox();
            datumRodjenjaKupca.Text = "datumRodjenjaKupca";
            datumRodjenjaKupca.Name = "datumRodjenjaKupca";
            datumRodjenjaKupca.Top = prezimeKupca.Top + 25;
            datumRodjenjaKupca.Left = prezimeKupca.Left;
            frm.Controls.Add(datumRodjenjaKupca);

            TextBox telefon = new TextBox();
            telefon.Text = "telefon";
            telefon.Name = "telefon";
            telefon.Top = datumRodjenjaKupca.Top + 25;
            telefon.Left = datumRodjenjaKupca.Left;
            frm.Controls.Add(telefon);

            TextBox pol = new TextBox();
            pol.Text = "pol";
            pol.Name = "pol";
            pol.Top = telefon.Top + 25;
            pol.Left = telefon.Left;
            frm.Controls.Add(pol);

            Button btn = new Button();
            btn.Text = "DODAJ";
            btn.Name = "btnDodajKupca";
            btn.Click += (s, f) =>
            {
                StreamWriter a = new StreamWriter("kupci.txt", true);
                a.WriteLine("ID Kupca: " + idKupca.Text.ToString());
                a.WriteLine("Ime Kupca: " + imeKupca.Text.ToString());
                a.WriteLine("Prezime Kupca: " + prezimeKupca.Text.ToString());
                a.WriteLine("Datum rodjenja kupca: " + datumRodjenjaKupca.Text.ToString());
                a.WriteLine("Telefon: " + telefon.Text.ToString());
                a.WriteLine("Pol: " + pol.Text.ToString());
                a.WriteLine(Environment.NewLine);
                a.Close();
                MessageBox.Show("Uspesno ste dodali kupca!");
                frm.Close();
            };
            btn.Location = new System.Drawing.Point(200, 200);
            frm.Controls.Add(btn);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Sale";

            TextBox idSale = new TextBox();
            idSale.Text = "idSale";
            idSale.Name = "idSale";
            idSale.Top = 25;
            idSale.Left = 25;
            frm.Controls.Add(idSale);


            TextBox brojSale = new TextBox();
            brojSale.Text = "brojSale";
            brojSale.Name = "brojSale";
            brojSale.Top = idSale.Top + 25;
            brojSale.Left = idSale.Left;
            frm.Controls.Add(brojSale);

            TextBox brojSedista = new TextBox();
            brojSedista.Text = "brojSedista";
            brojSedista.Name = "brojSedista";
            brojSedista.Top = brojSale.Top + 25;
            brojSedista.Left = brojSale.Left;
            frm.Controls.Add(brojSedista);          

            Button btn = new Button();
            btn.Text = "DODAJ";
            btn.Name = "btnDodajSalu";
            btn.Click += (s, f) =>
            {
                StreamWriter a = new StreamWriter("sale.txt", true);
                a.WriteLine("Id sale: " + idSale.Text.ToString());
                a.WriteLine("Broj sale: " + brojSale.Text.ToString());
                a.WriteLine("Broj sedista: " + brojSedista.Text.ToString());
                a.WriteLine(Environment.NewLine);
                a.Close();
                MessageBox.Show("Uspesno ste dodali salu!");
                frm.Close();
                main.form1.azurirajSale();

            };
            btn.Location = new System.Drawing.Point(200, 200);
            frm.Controls.Add(btn);
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Projekcije";

            TextBox idProjekcije = new TextBox();
            idProjekcije.Text = "idProjekcije";
            idProjekcije.Name = "idProjekcije";
            idProjekcije.Top = 25;
            idProjekcije.Left = 25;
            frm.Controls.Add(idProjekcije);


            TextBox datumProjekcije = new TextBox();
            datumProjekcije.Text = "datumProjekcije";
            datumProjekcije.Name = "datumProjekcije";
            datumProjekcije.Top = idProjekcije.Top + 25;
            datumProjekcije.Left = idProjekcije.Left;
            frm.Controls.Add(datumProjekcije);

            TextBox sala = new TextBox();
            sala.Text = "sala";
            sala.Name = "sala";
            sala.Top = datumProjekcije.Top + 25;
            sala.Left = datumProjekcije.Left;
            frm.Controls.Add(sala);

            TextBox cenaKarte = new TextBox();
            cenaKarte.Text = "cenaKarte";
            cenaKarte.Name = "cenaKarte";
            cenaKarte.Top = sala.Top + 25;
            cenaKarte.Left = sala.Left;
            frm.Controls.Add(cenaKarte);

            TextBox vremePocetkaProjekcije = new TextBox();
            vremePocetkaProjekcije.Text = "vremePocetkaProjekcije";
            vremePocetkaProjekcije.Name = "vremePocetkaProjekcije";
            vremePocetkaProjekcije.Top = cenaKarte.Top + 25;
            vremePocetkaProjekcije.Left = cenaKarte.Left;
            frm.Controls.Add(vremePocetkaProjekcije);

            TextBox film = new TextBox();
            film.Text = "film";
            film.Name = "film";
            film.Top = vremePocetkaProjekcije.Top + 25;
            film.Left = vremePocetkaProjekcije.Left;
            frm.Controls.Add(film);


            Button btn = new Button();
            btn.Text = "DODAJ";
            btn.Name = "btnDodajProjekciju";
            btn.Click += (s, f) =>
            {
                StreamWriter a = new StreamWriter("projekcije.txt", true);
                a.WriteLine("ID projekcije: " + idProjekcije.Text.ToString());
                a.WriteLine("Datum projekcije: " + datumProjekcije.Text.ToString());
                a.WriteLine("Sala: " + sala.Text.ToString());
                a.WriteLine("Cena karte: " + cenaKarte.Text.ToString());
                a.WriteLine("Vreme pocetka projekcije - " + vremePocetkaProjekcije.Text.ToString());
                a.WriteLine("Film: " + film.Text.ToString());
                a.WriteLine(Environment.NewLine);
                a.Close();
                MessageBox.Show("Uspesno ste dodali projekciju!");
                frm.Close();
            };
            btn.Location = new System.Drawing.Point(200, 200);
            frm.Controls.Add(btn);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Rezervacije";

            TextBox idRezervacije = new TextBox();
            idRezervacije.Text = "idRezervacije";
            idRezervacije.Name = "idRezervacije";
            idRezervacije.Top = 25;
            idRezervacije.Left = 25;
            frm.Controls.Add(idRezervacije);


            TextBox idKupca = new TextBox();
            idKupca.Text = "idKupca";
            idKupca.Name = "idKupca";
            idKupca.Top = idRezervacije.Top + 25;
            idKupca.Left = idRezervacije.Left;
            frm.Controls.Add(idKupca);

            TextBox brojMesta = new TextBox();
            brojMesta.Text = "brojMesta";
            brojMesta.Name = "brojMesta";
            brojMesta.Top = idKupca.Top + 25;
            brojMesta.Left = idKupca.Left;
            frm.Controls.Add(brojMesta);

            TextBox ukupnaCena = new TextBox();
            ukupnaCena.Text = "ukupnaCena";
            ukupnaCena.Name = "ukupnaCena";
            ukupnaCena.Top = brojMesta.Top + 25;
            ukupnaCena.Left = brojMesta.Left;
            frm.Controls.Add(ukupnaCena);

            Button btn = new Button();
            btn.Text = "DODAJ";
            btn.Name = "btnDodajRezervaciju";
            btn.Click += (s, f) =>
            {
                StreamWriter a = new StreamWriter("rezervacije.txt", true);
                a.WriteLine("ID rezervacije: " + idRezervacije.Text.ToString());
                a.WriteLine("ID kupca: " + idKupca.Text.ToString());
                a.WriteLine("Broj mesta: " + brojMesta.Text.ToString());
                a.WriteLine("Ukupna cena: " + ukupnaCena.Text.ToString());
                a.WriteLine(Environment.NewLine);
                a.Close();
                MessageBox.Show("Uspesno ste dodali rezervaciju!");
                frm.Close();
            };
            btn.Location = new System.Drawing.Point(200, 200);
            frm.Controls.Add(btn);
            frm.Show();
        }
    }
}
