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

namespace dinamicko_dugme
{
    public partial class Form1 : Form
    {
        Button[] dugme;
        TextBox[] txt;

        public Form1()
        {
            dugme = new Button[3] ;
            txt = new TextBox[3];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dugme[1] = new Button();
            dugme[1].Text = "unesi";
            dugme[1].Width = 50;
            dugme[1].Height = 50;
            dugme[1].Click += btn_unesi;
            dugme[1].Top = dugme[1].Height * 1;
            dugme[1].Left = dugme[1].Width ;
            this.Controls.Add(dugme[1]);

            dugme[2] = new Button();
            dugme[2].Text = "prikazi";
            dugme[2].Width = 50;
            dugme[2].Height = 50;
            dugme[2].Click += btn_procitaj;
            dugme[2].Top = dugme[2].Height * 2;
            dugme[2].Left = dugme[2].Width;
            this.Controls.Add(dugme[2]);

            txt[2] = new TextBox();
            txt[2].Text = "unesi";
            txt[2].Width = 150;
            txt[2].Height = 50;
            txt[2].Top = txt[2].Height * 3;
            txt[2].Left = txt[2].Width;
            this.Controls.Add(txt[2]);

            txt[1] = new TextBox();
            txt[1].Text = "prikazi";
            txt[1].Width = 150;
            txt[1].Height = 100;
            txt[1].Top = txt[1].Height * 6;
            txt[1].Left = txt[1].Width;
            this.Controls.Add(txt[1]);
        }
        public void btn_unesi(object sender, EventArgs e)
        {
            string tekst = txt[2].Text;
            string putanja = "da.txt";
            using (System.IO.StreamWriter File = new System.IO.StreamWriter("da.txt", true))
            {
                File.WriteLine(tekst);
            }
        }

        public void btn_procitaj(object sender, EventArgs e)
        {
            string tekst = txt[2].Text;
            string putanja = "da.txt";
            tekst = File.ReadAllText(putanja);
            txt[1].Text = tekst;
        }
    }
}
