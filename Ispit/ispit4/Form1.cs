﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispit4
{
    public partial class Form1 : Form
    {
        int visina;
        public Form1()
        {
            visina = ClientRectangle.Height / 2;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Y > visina)
            {
                this.BackColor = Color.AliceBlue;
            }
            else {
                this.BackColor = Color.Aquamarine;
            }
        }
    }
}
