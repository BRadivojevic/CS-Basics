﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "trenutna pozicija";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point tacka = this.PointToClient(Cursor.Position);
            int x = tacka.X;
            int y = tacka.Y;
            label1.Text = "trenutna pozicija"+" " + x + " " + y;
        }
    }
}
