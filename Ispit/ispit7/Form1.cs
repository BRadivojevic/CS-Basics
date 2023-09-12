using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit7
{
    public partial class Form1 : Form

    {
        Button[] dugme;
        public Form1()
        {
            dugme = new Button[3];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dugme[1] = new Button();
            dugme[1].Text = "Promeni";
            dugme[1].Width = 100;
            dugme[1].Height = 50;
            dugme[1].Top = dugme[1].Height;
            dugme[1].Left = dugme[1].Width;
            dugme[1].MouseHover += btn_hover;
            this.Controls.Add(dugme[1]);


            dugme[2] = new Button();
            dugme[2].Text = "Promeni";
            dugme[2].Width = 100;
            dugme[2].Height = 50;
            dugme[2].Top = dugme[1].Height * 4;
            dugme[2].Left = dugme[1].Width;
           
            this.Controls.Add(dugme[2]);



        }
        public void btn_hover(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));

            dugme[2].BackColor = boja;
        }
    } 
}
