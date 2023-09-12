using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrica
{
    public partial class Form1 : Form
    {
        Button[,] matrica;
        int visina;
        int sirina;
        public Form1()
        {
            matrica = new Button[5,5];
            racDim();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                {
                    matrica[x, y] = new Button();
                    matrica[x, y].Text = x + " ," + y;
                    matrica[x, y].BackColor = Color.FromArgb(0 + x * 45,255 - y * 50, 90);
                    matrica[x, y].Click += btn_klik;
                    this.Controls.Add(matrica[x, y]);


                }menjanjeDim();
        }
        public void btn_klik(object sender, EventArgs e)
        { 
        Button b=sender as Button;
            MessageBox.Show(b.Text);
        
        }

        public void menjanjeDim()
        {
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                {
                    matrica[x, y].Width = sirina;
                    matrica[x, y].Height = visina;
                    matrica[x, y].Top = matrica[x, y].Height*x;
                    matrica[x, y].Left = matrica[x, y].Width * y;

                }
           

        }

        public void racDim()
        {
            visina = this.ClientRectangle.Height / 5;
            sirina = this.ClientRectangle.Width / 5;
        
        }


    }
}
