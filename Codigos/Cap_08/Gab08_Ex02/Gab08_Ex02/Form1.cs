using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gab08_Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float F, C;
            F = float.Parse(textBox1.Text);
            C = ((F - 32) * 5) / 9;
            label1.Text = C.ToString();
        }
    }
}
