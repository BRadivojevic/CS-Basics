using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    { public static Color boja;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("crvena");
            comboBox1.Items.Add("plava");
            comboBox1.Items.Add("random");
            comboBox1.Items.Add("zelena");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "crvena":
                    boja = Color.Red;
                    break;
                case "plava":
                    boja = Color.Blue;
                    break;
                case "random":
                    Random rnd = new Random(DateTime.Now.Second);
                    boja = Color.FromArgb(rnd.Next(1,255), rnd.Next(1, 255), rnd.Next(1, 255));
                    break;
                case "zelena":
                    boja = Color.Green;
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
