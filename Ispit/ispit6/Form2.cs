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

    public partial class Form2 : Form
    {
        public static string boja1 = "";


        public Form2()
        {

            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            boja1 = Form1.boja;

            switch (boja1)
            {
                case "Zelena":
                    label1.ForeColor = Color.Green;
                    break;
                case "Plava":
                    label1.ForeColor = Color.Blue;
                    break;
                case "Orange":
                    label1.ForeColor = Color.Orange;
                    break;
                case "Crvena":
                    label1.ForeColor = Color.Red;
                    break;
                case "Zuta":
                    label1.ForeColor = Color.Yellow;
                    break;
                default:
                    break;

            }

        }
    }
}
