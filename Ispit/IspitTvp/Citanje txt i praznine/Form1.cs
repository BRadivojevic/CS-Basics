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

namespace Citanje_txt_i_praznine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = textBox2.Text;
            string putanja = textBox1.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string putanja = textBox1.Text;
            string tekst = File.ReadAllText(putanja);
            textBox2.Text = tekst;

            label1.Text = "Broj praznina: "+ brojP(putanja).ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Broj praznina: ";
        }

        public int brojP(string putanja)
        {
            string tekst = textBox2.Text;
            int brojP = 0;
            foreach (char slovo in tekst)
            if(slovo=='\n'||slovo=='\t'||slovo==' ')
                {
                    brojP++;
                }

            return brojP; ;
        }
    }
}
