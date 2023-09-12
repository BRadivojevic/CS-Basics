using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Za6
{
    public partial class Form2 : Form
    {
        List<Student> studenti;

        public Form2(List<Student> upisani)
        {
            this.studenti = upisani;
            InitializeComponent();
        }

   

        private void Form2_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.AutoSize = true;

            foreach (Student student in studenti)
            {
                l.Text = student.ToString();
            }
            this.Controls.Add(l);

        }
    }
}
