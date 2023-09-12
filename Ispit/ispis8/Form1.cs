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

namespace ispis8
{
    public partial class Form1 : Form
    { 
        string putanja;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {    string putanja = textBox1.Text;
            string tekst = File.ReadAllText(putanja);
            if (File.Exists(putanja))
            {
                label1.Text += " " + " " + prikaz_dat(putanja).ToString();
            }
            else
            {
                MessageBox.Show("Ne postoji putanja");
            }

        }
        private int prikaz_dat(string putanja)
        {

            string tekst = File.ReadAllText(putanja);
            int brojPraz = 0;
            foreach (char slovo in tekst)
                if (slovo == '\n' || slovo == ' ' || slovo == '\t')
                    brojPraz++;
            return brojPraz;
               
                  
        }
    }
}
