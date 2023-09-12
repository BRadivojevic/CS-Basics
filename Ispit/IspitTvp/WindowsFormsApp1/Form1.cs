using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void MetodA()
        {
            foreach (Control x in this.Controls)
                if (x.GetType() == typeof(RadioButton))
                { ((RadioButton)x).Checked = true; }
                else if (x.GetType() == typeof(ListBox))
                { ((ListBox)x).Items.Add("Izaberite..."); }
                else if (x.GetType() == typeof(TextBox))
                { x.BackColor = Color.Green; }
                else if (x.GetType() == typeof(Label))
                { x.ForeColor = Color.Red; }
                else if (x.GetType() == typeof(Button))
                { x.Width = x.Height; }
                else if (x.GetType() == typeof(CheckBox))
                { ((CheckBox)x).Checked = true; }


        }
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
          MetodA();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
