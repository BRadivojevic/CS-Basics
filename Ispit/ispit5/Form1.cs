using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Random random = new Random(DateTime.Now.Millisecond);
            Rectangle kocka = new Rectangle(random.Next(1, 400), random.Next(1, 400), 50, 50);
            Color boja=Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255));
            SolidBrush cetkica = new SolidBrush(boja);
            g.FillRectangle(cetkica, kocka);
        }
    }
}
