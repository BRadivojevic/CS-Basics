using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit9
{
    public partial class Form1 : Form
    {
      int  brojac=0;
        Button[] dugme;
        public Form1()
        {
            dugme = new Button[5];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dugme[i] = new Button();
                dugme[i].Width = 100;
                dugme[i].Height = 150;
                dugme[i].Top = dugme[i].Height * i;
                dugme[i].Left = dugme[i].Width;
                dugme[i].Click += btn_Click;
                this.Controls.Add(dugme[i]);

            }
        }
            private void btn_Click(object sender,EventArgs e)
            { brojac++;
            MessageBox.Show("Brojac je:" + brojac);
            }


        }
    }

