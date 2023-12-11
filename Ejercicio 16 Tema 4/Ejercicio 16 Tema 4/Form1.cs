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
            //? Cambiamos la inicialización de factorial a 1.
            int factorial = 1;
            //? Inicialización de i = n.
            int i = n;
            while(i > 0)
            {
                //? Cambiamos suma por multiplicación
                factorial *= i;
                i--;
            }
            return factorial;
        }
        private void factorialBtn_Click(object sender, EventArgs e)
        {
            int nRMB2324;
            nRMB2324 = int.Parse(txtN.Text);

            MessageBox.Show("El factorial de " + nRMB2324 + " es " + calculaFactorial(nRMB2324));
        }
    }
}
