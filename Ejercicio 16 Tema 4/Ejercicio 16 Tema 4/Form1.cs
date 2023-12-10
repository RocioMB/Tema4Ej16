using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_16_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int calculaFactorial(int n)
        {
            int factorial = 1;
            int i = n;
            while(i > 0)
            {
                factorial *= i;
                i--;
            }
            return factorial;
        }
        private void factorialBtn_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtN.Text);

            MessageBox.Show("El factorial de " + n + " es " + calculaFactorial(n));
        }
    }
}
