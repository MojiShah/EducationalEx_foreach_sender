using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalEx_foreach_sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hello_func(object sender, EventArgs e)
        {
            string s;

            /*s = "Hello "+ ((Button)sender).Text;
             * s = "Hello "+ ((Control)sender).Name;*/

            //s = "Hello "+ ((Control)sender).Name;
            //MessageBox.Show(s);

            /*
             *((Button)sender).ForeColor= Color.Red;
             * 
             * 
             */
            //((Control)sender).ForeColor= Color.Red;
            //((Control)sender).BackColor= Color.Yellow;

            foreach (Control m in this.Controls)
            {
                if(m.Equals(sender))
                {
                    m.ForeColor = Color.RosyBrown;
                    m.BackColor = Color.HotPink;
                }
                else
                {
                    m.ForeColor = Color.Black;
                    m.BackColor = Color.LightCyan;
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int []a = new int[5];
            //a[0] = 10;
            //a[1] = 20;
            //a[3] = 30;
            //a[4] = 40;

            //int[] b = { 50, 60, 70, 80, 90, 100 };

            ///*for (int i = 0;i < a.Length; i++) 
            //{
            //    MessageBox.Show(a[i].ToString());
            //}

            //for(int j=0;j<b.Length;j++)
            //{
            //    // MessageBox.Show(Convert.ToString(b[j]));
            //    MessageBox.Show((string)b[j].ToString());
            //}
            //*/

            //foreach (int i in a) {
            //    MessageBox.Show(i.ToString());
            //}

            //foreach (int j in b)
            //{
            //    MessageBox.Show(j.ToString());
            //}

            foreach (Control c in this.Controls)
            {
                //MessageBox.Show(c.Text);
                if (c.Text == "Reza")
                    c.BackColor = Color.Lime;
                else if (c.Text == "Moji")
                    c.ForeColor = Color.Red;
                else {
                    c.Width += 20;
                    c.Height += 5;
                }
                
           
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Text = "Moji Shah";
            label1.Click += new EventHandler(func1);
        }

        private void func1(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
        }
    }
}
