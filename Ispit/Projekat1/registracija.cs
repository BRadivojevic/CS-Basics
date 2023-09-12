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
    public partial class registracija : Form
    {
        public registracija()
        {
            InitializeComponent();
        }

        private void registracija_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Niste popunili sva polja.", "Greska 02");
            }
            else
            {
                StreamWriter a = new StreamWriter("korisnici.txt", true);
                a.WriteLine(textBox1.Text.ToString());
                a.WriteLine(textBox2.Text.ToString());
                //a.WriteLine("Admin: Ne");
                a.Close();
                MessageBox.Show("Uspesno ste napravili nalog!");
                //if(textBox1.Text == ime && textBox2.Text == lozinka)
                //{
                //   main.form1.enableB();
                //   MessageBox.Show("Uspesno ste se prijavili kao administrator.");
                //   this.Close();
                //}
                this.Close();
            }
            

        }
    }
}
