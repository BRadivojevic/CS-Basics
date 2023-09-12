using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel_sa_bojama
{
    public partial class Form1 : Form
    {
        Panel[] panel;
        public Form1()
        {
            panel = new Panel[3];
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int visina = panel1.ClientRectangle.Height;
          int  sirina = panel1.ClientRectangle.Width / 2;

            panel[1] = new Panel();
            panel[1].Width = sirina;
            panel[1].Height = visina;
            panel[1].MouseHover += promeni1;
            panel[1].MouseLeave += vrati1;
            panel[1].Click += klik1;
            panel[1].BackColor = Color.Red;
            panel1.Controls.Add(panel[1]);

            panel[2] = new Panel();
            panel[2].Width = panel[1].Width * 2;
            panel[2].Height = visina;
            panel[2].MouseHover += promeni2;
            panel[2].MouseLeave += vrati2;
            panel[2].Click += klik2;
            panel[2].BackColor = Color.Blue;
            panel1.Controls.Add(panel[2]);
        }
        public void promeni2(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
            panel[2].BackColor = boja;
        }

        public void promeni1(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
            panel[1].BackColor = boja;
        }

        public void vrati2(object sender, EventArgs e)
        {


            panel[2].BackColor = Color.Blue;
        }
        public void vrati1(object sender, EventArgs e)
        {

            panel[1].BackColor = Color.Red;
        }
        public void klik1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void klik2(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
