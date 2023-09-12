using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hover_za_dugme
{
    public partial class Form1 : Form
        
    {
        public void metoda()
        {
            foreach (Control x in this.Controls)
                if (x.GetType() == typeof(Button))
                {
                    Random rnd = new Random(DateTime.Now.Millisecond);
                    Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
                    ((Button)x).MouseHover += btn_hover;
                    
                    
                }
            
           

        }
        public void btn_hover(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
                if (x.GetType() == typeof(Button))
                {
                    Random rnd = new Random(DateTime.Now.Millisecond);
                    Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
                    ((Button)x).MouseHover += btn_hover;
                    ((Button)x).BackColor = boja;
                    

                }
            return btn_hover;


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x.GetType() == typeof(Button))
                {
                    Random rnd = new Random(DateTime.Now.Millisecond);
                    Color boja = Color.FromArgb(rnd.Next(1, 255), rnd.Next(1, 255), rnd.Next(1, 255));
                    ((Button)x).MouseHover += btn_hover;


                }
        }
    }
}
