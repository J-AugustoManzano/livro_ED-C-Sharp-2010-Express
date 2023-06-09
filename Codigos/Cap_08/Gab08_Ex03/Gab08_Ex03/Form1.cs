using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gab08_Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, X;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            X = A;
            A = B;
            B = X;
            label1.Text = A.ToString();
            label2.Text = B.ToString();
        }
    }
}
