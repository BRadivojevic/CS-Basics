using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit6
{
    public partial class Form1 : Form
    {
        public static string boja="";
        
        public Form1()
        {
           

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Zelena");
            comboBox1.Items.Add("Plava");
            comboBox1.Items.Add("Zuta");
            comboBox1.Items.Add("Crvena");
            comboBox1.Items.Add("Orange");

            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    boja = "Zelena";
                    break;
                case 1:
                    boja = "Plava";
                    break;
                case 2:
                    boja = "Zuta";
                    break;
                case 3:
                    boja = "Crvena";
                    break;
                case 4:
                    boja = "Orange";
                    break;
                default:
                    break;
            }

            var form2 = new Form2();
            form2.Show();





        }
    }
}
