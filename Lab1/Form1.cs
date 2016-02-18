using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;  

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long a;
        long m;;
        long c;
        long x0;
        long x;
        long len;
        long[] X;
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {

            try 
            {
                a = Convert.ToInt64(textBox1.Text);
                c = Convert.ToInt64(textBox2.Text);
                m = Convert.ToInt64(textBox3.Text);
                x0 = Convert.ToInt64(textBox4.Text);
                len = Convert.ToInt64(textBox5.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невірні дані");
            }
            X = new long[len];
            X[0] = x0;
            for (int i = 1; i < len; i++)
            {
                x = (a * X[i-1] + c) % m;
                textBox6.Text = textBox6.Text + x.ToString()+"         ";
                if (X.Contains(x))
                {
                    MessageBox.Show("Первіод рівний "+i.ToString());
                    flag = true;
                }
                X[i] = x;
            }
            if(!flag)
                MessageBox.Show("Первіод більший "+len.ToString());
            
        }
    }
}
