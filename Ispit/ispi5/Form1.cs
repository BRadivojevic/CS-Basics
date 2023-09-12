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

namespace ispi5
{
    public partial class Form1 : Form
    {
        Button[] dugme;
        TextBox[] txtbox;
        public Form1()
        {
            dugme = new Button[3];
            txtbox = new TextBox[3];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dugme[1] = new Button();
            dugme[1].Width = 50;
            dugme[1].Height = 50;
            dugme[1].Text = "Unesi";
            dugme[1].Top = dugme[1].Height * 1;
            dugme[1].Left = dugme[1].Width;
            dugme[1].Click += btn_klik;
            this.Controls.Add(dugme[1]);

            dugme[2] = new Button();
            dugme[2].Width = 50;
            dugme[2].Height = 50;
            dugme[2].Text = "Procitaj";
            dugme[2].Top = dugme[2].Height * 2;
            dugme[2].Left = dugme[2].Width;
            dugme[2].Click += btn_citaj;
            this.Controls.Add(dugme[2]);



            txtbox[1] = new TextBox();
            txtbox[1].Width = 200;
            txtbox[1].Height = 150;
            txtbox[1].Top = txtbox[1].Height * 3;
            txtbox[1].Left = txtbox[1].Width;
            this.Controls.Add(txtbox[1]);

            txtbox[2] = new TextBox();
            txtbox[2].Width = 200;
            txtbox[2].Height = 200;
            txtbox[2].Top = txtbox[2].Height * 5;
            txtbox[2].Left = txtbox[2].Width;
            this.Controls.Add(txtbox[2]);





        }

        private void btn_klik(object sender, EventArgs e)
        {
            string tekst = txtbox[1].Text;

            using (System.IO.StreamWriter file =
        new System.IO.StreamWriter("doc.txt", true))
            {
                file.WriteLine(tekst);
            };


        }
        string putanja = "doc.txt";

        public void btn_citaj(object sender, EventArgs e)
        {
            string tekst = File.ReadAllText(putanja);
            txtbox[2].Text = tekst;
        }
    }
}

