using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Za6
{
    public partial class Form1 : Form
    {
        List<Student> studenti;
        List<Student> upisani;
        private string ime, prezime, indeks;
        private int godine;
        public Form1()
        {
            InitializeComponent();
            upisani = new List<Student>();
            studenti = new List<Student>();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ime = textBox1.Text;
            if (!string.IsNullOrEmpty(ime))
            {
                if (char.IsUpper(ime[0]) && ime.Length >= 2)
                    textBox1.BackColor = Color.Green;
                else
                {
                    textBox1.BackColor = Color.Red;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
                MessageBox.Show("Polje ime ne moze biti prazno!");
            else if (textBox2.Text.Trim().Length == 0)
                MessageBox.Show("Polje prezime ne moze biti prazno!");
            else if (textBox3.Text.Trim().Length == 0)
                MessageBox.Show("Polje godine ne moze biti prazno!");
            else if (!int.TryParse(textBox3.Text, out godine))
                MessageBox.Show("polje godine mora biti broj");
            else if (textBox4.Text.Trim().Length == 0)
                MessageBox.Show("Polje indeks ne moze biti prazno!");
            else
            {
                Student s = new Student();
                s.Ime = ime;
                s.Prezime = prezime;
                s.Godine = godine;
                s.Indeks = indeks;
                studenti.Add(s);
                MessageBox.Show("Uspesno ste snimili studenta!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            indeks = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out godine))
            {
                textBox3.BackColor = Color.Red;
            }
            else if (godine < 18)
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = Color.Green;
                godine = int.Parse(textBox3.Text);
            }
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            upisani = studenti;
            Form2 frm = new Form2(upisani);
            frm.Show();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            prezime = textBox2.Text;
            if (!string.IsNullOrEmpty(prezime))
            {
                if (char.IsUpper(prezime[0]) && prezime.Length >= 2)
                    textBox2.BackColor = Color.Green;
                else
                {
                    textBox2.BackColor = Color.Red;
                    return;
                }
            }
        }
    }
}

