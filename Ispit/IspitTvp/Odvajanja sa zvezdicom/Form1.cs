using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odvajanja_sa_zvezdicom
{ 
    public partial class Form1 : Form
    {
        public string putanja;
        public string tekst;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = textBox2.Text;
            string putanja = textBox1.Text;
            tekst = tekst.Replace('*', '\n');
            using (System.IO.StreamWriter File = new System.IO.StreamWriter(putanja, true))
            {
                File.WriteLine(tekst);
            }
        }
    }
}
