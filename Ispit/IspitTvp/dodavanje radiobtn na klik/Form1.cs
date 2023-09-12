using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodavanje_radiobtn_na_klik
{
    public partial class Form1 : Form
    { RadioButton dugme;
        public Form1()
        {
            dugme = new RadioButton();
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point tacka = this.PointToClient(Cursor.Position);
            dugme = new RadioButton();
           dugme.Location = tacka;
            this.Controls.Add(dugme);
            dugme.Checked = true;
        }
    }
}
