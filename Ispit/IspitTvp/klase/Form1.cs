using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klase
{
    public partial class Form1 : Form
    {
        FileStream fb, fs;
      
      
        
        public Form1()
        { 
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pravougaonik p = new pravougaonik(float.Parse(textBox1.Text), float.Parse(textBox2.Text));

       //     String[] YogiArray = { textBox1.Text, textBox2.Text };
       //foreach (string Booboo in YogiArray)
       //     {
       //         listBox1.Items.Add(Booboo);
       //     }
            int broj = 0;

            string[] niz = new string[10];
            //And on your Button click event

            if (broj < niz.Length)
            {
                niz[broj] = textBox1.Text;
                listBox1.Items.Add(niz[broj++]);
            }
            else { MessageBox.Show("nema mesta u nizu"); }
            
            }
       

        }
        //private void upisi(object o)
        //{
        //    try
        //    {
        //        fb = new FileStream("studenti.bin", FileMode.Create);
        //        fs = new FileStream("studenti.xml", FileMode.Create);

        //        BinaryFormatter binform = new BinaryFormatter();
        //        SoapFormatter soapform = new SoapFormatter();

        //        binform.Serialize(fb, o);
        //        soapform.Serialize(fs, o);

        //        fb.Flush(); fs.Flush();
        //        fb.Close(); fs.Close();

        //        MessageBox.Show("ok");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }

