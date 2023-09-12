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
    public partial class loginKorisnik : Form
    {
        public static Boolean jeAdmin = false;
        public loginKorisnik()
        {
            InitializeComponent();
        }

        public static string ime = "";
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registracija forma2 = new registracija();
            forma2.Show();
            //Form frm = new Form();
            //frm.Text = "Registracija korisnika";

            //TextBox ime = new TextBox();
            //ime.Text = "ime";
            //ime.Name = "ime";
            //ime.Top = 25;
            //ime.Left = 25;
            //frm.Controls.Add(ime);

            //TextBox lozinka = new TextBox();
            //lozinka.Text = "lozinka";
            //lozinka.Name = "lozinka";
            //lozinka.Top = ime.Top + 25;
            //lozinka.Left = ime.Left;
            //frm.Controls.Add(lozinka);

            //Button btn = new Button();
            //btn.Text = "REGISTRUJ SE";
            //btn.Name = "btnRegistruj";

            //btn.Location = new System.Drawing.Point(200, 200);
            //frm.Controls.Add(btn);
            //btn.Click += (s, f) =>
            //{
            //    string[] polja =
            //        {
            //            ime.Text.ToString(),
            //            lozinka.Text.ToString(),    

            //        };
            //    File.WriteAllLines("korisnici.txt", polja);
            //    frm.Close();
            //};
            //frm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string pass = textBox2.Text.ToString();

            if (File.Exists("korisnici.txt"))
            {
                StreamReader ab = new StreamReader("korisnici.txt");          

                string line1 = ab.ReadLine();
                string line2 = ab.ReadLine();
                if ((username == "") || (pass == ""))
                {
                    MessageBox.Show("Niste uneli sva polja.", "Greska 04");
                               
                }
                else
                {
                    while ((line1 != null) && (line2 != null))
                    {

                        if ((line1 == username) && (line2 == pass))
                        {
                            MessageBox.Show("Dobrodosli " + username.ToString() + ".");

                            this.Hide();
                            rezervacije forma1 = new rezervacije();
                            forma1.Show();
                            ime = username;
                            break;

                            
                        }
                        else
                        {
                            MessageBox.Show("Korisnik sa tim podacima ne postoji.", "Greska 03");
                            break;
                        }

                        line1 = ab.ReadLine();
                        line2 = ab.ReadLine();
                    }



                    ab.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Ne postoji datoteka sa korisnicima. \nRegistrujte novi nalog.", "Greska 01");
            }
          
        }
    }
}
