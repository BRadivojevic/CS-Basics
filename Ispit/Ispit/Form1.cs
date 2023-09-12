using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispit
{
    public partial class Form1 : Form
    {
        int visina;
        int sirina;
        Button[,] matrica;

        public Form1()
        {
            matrica = new Button[5, 5];
            racDim();
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    matrica[i, j] = new Button();
                    matrica[i, j].Text = i + "," + j;
                    matrica[i, j].BackColor = Color.FromArgb(0 + i * 55, 255 - j * 45, 90);
                    matrica[i, j].Click += btn_Click;
                    this.Controls.Add(matrica[i, j]);

                }
            menjDim();
        }
        private void racDim()
        {
            sirina = this.ClientRectangle.Width / 5;
            visina = this.ClientRectangle.Height / 5;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Text);

        }
        private void menjDim()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {

                    matrica[i, j].Width = sirina;
                    matrica[i, j].Height = visina;
                    matrica[i, j].Top = visina * i;
                    matrica[i, j].Left = sirina * j;

                }
        }
    }
}
