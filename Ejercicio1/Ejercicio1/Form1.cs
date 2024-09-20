using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                double numero1 = Convert.ToDouble(tbNum1.Text);
                double numero2 = Convert.ToDouble(tbNum2.Text);
                char operacion = Convert.ToChar(tbOperacion.Text);

                // Clase Calculadora
                Calculadora calculadora = new Calculadora();

                // Realizar la operación
                double resultado = calculadora.Operar(numero1, numero2, operacion);

                // Mostrar el resultado en un MessageBox
                MessageBox.Show("El resultado es: " + resultado.ToString(), "Resultado");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
