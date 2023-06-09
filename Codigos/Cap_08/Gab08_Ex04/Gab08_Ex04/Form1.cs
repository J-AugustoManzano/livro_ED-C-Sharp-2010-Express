using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gab08_Ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C, DELTA, X1, X2;
            A = double.Parse(textBox1.Text); 
            B = double.Parse(textBox2.Text);
            C = double.Parse(textBox3.Text);            
            if (A != 0 && B != 0 && C != 0)
            {
                DELTA = Math.Pow(B, 2) * 4 * A * C;
                if (DELTA == 0)
                {
                    X1 = -B / (2 * A);
                    MessageBox.Show("X = " + X1.ToString("0.00"));
                }
                else
                    if (DELTA > 0)
                    {
                        X1 = (-B + Math.Sqrt(DELTA)) / (2 * A);
                        X2 = (-B - Math.Sqrt(DELTA)) / (2 * A);
                        MessageBox.Show("X1 = " + X1.ToString("0.00") + 
                        " X2 = " + X2.ToString("0.00"));
                    }
                    else
                        MessageBox.Show("Nao existem raizes reais");
            }
            else
                MessageBox.Show("Nao e equacao completa de 2o. grau.");

        }
    }
}
