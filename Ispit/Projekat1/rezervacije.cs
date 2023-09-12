using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class rezervacije : Form
    {
        public rezervacije()
        {
            InitializeComponent();
        }

        private void rezervacije_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main formaGlavna = new main();
            formaGlavna.Show();
        }
    }
}
