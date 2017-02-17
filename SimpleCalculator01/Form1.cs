using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sum(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* int x = int.Parse(textBox1.Text);
             int y = int.Parse(textBox2.Text);

             label1.Text = (x -y).ToString();*/
            Sum(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void Sum(int i)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (i == 1)
            {
                

                label1.Text = (x + y).ToString();
            }
            else
            {
                

                label1.Text = (x - y).ToString();
            }
        }
    }
}
