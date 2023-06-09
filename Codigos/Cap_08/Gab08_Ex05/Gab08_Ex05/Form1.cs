using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gab08_Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float N1, N2, N3, N4, MD1, EX, MD2;
            N1 = float.Parse(textBox1.Text);
            N2 = float.Parse(textBox2.Text);
            N3 = float.Parse(textBox3.Text);
            N4 = float.Parse(textBox4.Text);
            MD1 = (N1 + N2 + N3 + N4) / 4;
            if (MD1 >= 7)
                MessageBox.Show("Aprovado com media " + MD1.ToString("0.00"));
            else
            {
                EX = float.Parse(textBox5.Text);
                MD2 = (MD1 + EX) / 2;
                if (MD2 >= 5)
                    MessageBox.Show("Aprovado em exame com media " + MD2.ToString("0.00"));
                else
                    MessageBox.Show("Reprovado com media " + MD2.ToString("0.00"));
            }

        }
    }
}
