using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitina
{
    public partial class Form1 : Form
    {
        Button[,] matrica;
        int visina;
        int sirina;
        public Form1()
        {
            InitializeComponent();
            matrica = new Button[5, 5];
            racDim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                {
                    matrica[x, y] = new Button();

                    matrica[x, y].Text = x + " , " + y;
                    matrica[x, y].Click += btn_Klik;
                    this.Controls.Add(matrica[x, y]);
                }
            menjanjeDim();

        }
        public void menjanjeDim()
        {
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                {

                    matrica[x, y].Width = sirina;
                    matrica[x, y].Height = visina;
                    matrica[x, y].Top = matrica[x, y].Height * x;
                    matrica[x, y].Left = matrica[x, y].Width * y;


                }

        }
        public void racDim()
        {
            visina = this.ClientRectangle.Width / 5;
            sirina = this.ClientRectangle.Height / 5;
        }

        public void btn_Klik(object sender, EventArgs e)
        {

            //MessageBox.Show()
        }
    }
}
