using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapirSaWa
{
    public partial class Form1 : Form
    {
        int broj = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj++;
            textBox1.Text = broj.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            broj--;
            textBox1.Text = broj.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int broj = 10;
            textBox1.Text = broj.ToString();
        }
    }
}
