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

namespace beli_znakovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string putanja = textBox1.Text;

            string tekst = File.ReadAllText(putanja);
            textBox2.Text = tekst;
            label1.Text += " " + prikazi(putanja).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Broj praznina u txt: ";
        }

        private int prikazi(string putanja)
        {
            string tekst = File.ReadAllText(putanja);
            int brojB = 0;
            foreach (char slovo in tekst)
                if (char.IsWhiteSpace(slovo)/*slovo=='\n'||slovo=='\t'||slovo==' '*/)
                {
                    brojB++;
                    label1.Text = "Broj praznina u txt:" + brojB;
                }return brojB;
        }
    }
}
