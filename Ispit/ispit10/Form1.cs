using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit10
{
    public partial class Form1 : Form
    {
        public string tekst;
        public string zarez;

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string putanja = textBox2.Text;
            string tekst = textBox1.Text;
            tekst = tekst.Replace(',', '\n');

                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(putanja, true))
                {
                    file.WriteLine(tekst);
                }
            }




        }
    }

    

