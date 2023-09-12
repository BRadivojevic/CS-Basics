using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit2
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point tacka = this.PointToClient(Cursor.Position);
            e.Graphics.DrawEllipse(Pens.Blue, tacka.X - 25, tacka.Y - 25, 50, 50);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
        }
    }  
}



