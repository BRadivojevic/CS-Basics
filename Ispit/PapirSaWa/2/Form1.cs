﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public static string tekst;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tekst = textBox1.Text;

            int brS = 0;
            foreach (char slovo in tekst)
                if (slovo == 'a' || slovo == 'A' || slovo == 'e' || slovo == 'E' || slovo == 'i' || slovo == 'I' || slovo == 'o' || slovo == 'O' || slovo == 'u' || slovo == 'U')
                {
                    brS++;
                    label1.Text = brS.ToString();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
