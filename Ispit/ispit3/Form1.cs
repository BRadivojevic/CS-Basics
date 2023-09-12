using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit3
{
    public partial class Form1 : Form
    { int brojac;
        Button[] dugme;
        Label[] labela;
        
        public Form1()
        {
            brojac = 0;
            dugme = new Button[2];
            labela = new Label[2];
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                dugme[i] = new Button();
                dugme[i].BackColor = Color.Yellow;
                dugme[i].Height = 50;
                dugme[i].Width = 50;
                dugme[i].Top = dugme[i].Height * i;
                dugme[i].Left = dugme[i].Width ;
                this.Controls.Add(dugme[i]);


            }
            for (int j = 0; j < 2; j++)
            {
                labela[j] = new Label();
                labela[j].ForeColor = Color.Pink;
                labela[j].Height = 80;
                labela[j].Width = 100;
                labela[j].Text = "Labela";
                labela[j].Top = labela[j].Height * j;
                labela[j].Left = labela[j].Width;
                this.Controls.Add(labela[j]);


            }
        }
    }
}
