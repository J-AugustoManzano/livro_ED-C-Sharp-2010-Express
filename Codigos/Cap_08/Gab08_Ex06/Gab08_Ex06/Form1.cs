using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gab08_Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SOMA, I, RESTO;

            SOMA = 0;
            for (I = 0; I <= 20; I++)
            {
                RESTO = I % 2;
                if (RESTO != 0)
                    SOMA += I;
            }
            MessageBox.Show(SOMA.ToString());
        }
    }
}
