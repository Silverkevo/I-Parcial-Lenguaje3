using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if (Numero1textBox.Text == "")
            {
                errorProvider1.SetError(Numero1textBox, "Ingrese un valor ");
                return;
            }
            errorProvider1.Clear();
            if (Numero2textBox.Text == string.Empty)
            {
                errorProvider1.SetError(Numero2textBox, "Ingrese un valor ");
                return;
            }
            errorProvider1.Clear();

            if (OperacionesComboBox.Text == string.Empty)
            {
                errorProvider1.SetError(OperacionesComboBox, "Seleccione una operación: ");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox.Text);
            ResultadoLabel.Text = Calcular(num1, num2).ToString();

        }

        private decimal Calcular(decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox.Text;

            decimal resultado = 0;
            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "División")
            {
                if (n2 == 0)
                    resultado = 0;
                else
                   resultado = n1 / n2;
            }
            return resultado;
        }
    }
}
