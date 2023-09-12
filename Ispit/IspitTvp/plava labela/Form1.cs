using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plava_labela
{
    public partial class Form1 : Form
    {
        public void metoda()
        {
            foreach (Control x in this.Controls)
                if (x.GetType() == typeof(Label))
                {
                    ((Label)x).ForeColor = Color.Blue;
                }
                else if (x.GetType() == typeof(Button))
                {
                    ((Button)x).BackColor = Color.Red;
                }
        
        
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metoda();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
