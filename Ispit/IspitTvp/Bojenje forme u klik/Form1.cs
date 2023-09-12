using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bojenje_forme_u_klik
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int visina = this.ClientRectangle.Height / 2;
            if (e.Y > visina)
            {
                this.BackColor = Color.Red;

            }
            else { this.BackColor = Color.Blue; }
        
        
        }
    }
}
