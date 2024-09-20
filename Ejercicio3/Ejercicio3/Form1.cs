using Ejercicio3.Models; // Importa la clase Matriz
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        // Variables para las matrices 4x4
        private int[,] matriz1 = new int[4, 4];
        private int[,] matriz2 = new int[4, 4];
        private int filaActual1 = 0, columnaActual1 = 0;
        private int filaActual2 = 0, columnaActual2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatriz1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lee el valor del TextBox
                int valor = int.Parse(tbMatriz1.Text);

                // Guarda el valor en la matriz1
                matriz1[filaActual1, columnaActual1] = valor;

                // Incrementa el índice de la columna y fila para pasar al siguiente valor
                columnaActual1++;
                if (columnaActual1 == 4)
                {
                    columnaActual1 = 0;
                    filaActual1++;
                }

                // Limpia el TextBox para el siguiente valor
                tbMatriz1.Clear();

                // Verifica si ya se llenó toda la matriz
                if (filaActual1 == 4)
                {
                    MessageBox.Show("Matriz 1 completa.");
                    btnMatriz1.Enabled = false; // Deshabilita el botón
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnMatriz2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lee el valor del TextBox
                int valor = int.Parse(tbMatriz2.Text);

                // Guarda el valor en la matriz2
                matriz2[filaActual2, columnaActual2] = valor;

                // Incrementa el índice de la columna y fila para pasar al siguiente valor
                columnaActual2++;
                if (columnaActual2 == 4)
                {
                    columnaActual2 = 0;
                    filaActual2++;
                }

                // Limpia el TextBox para el siguiente valor
                tbMatriz2.Clear();

                // Verifica si ya se llenó toda la matriz
                if (filaActual2 == 4)
                {
                    MessageBox.Show("Matriz 2 completa.");
                    btnMatriz2.Enabled = false; // Deshabilita el botón
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Asegúrate de que ambas matrices estén completas antes de realizar la suma
            if (filaActual1 == 4 && filaActual2 == 4)
            {
                // Instancia de la clase Matriz para realizar la operación
                Matriz matrizOperacion = new Matriz();

                // Realiza la suma de las dos matrices
                int[,] resultado = matrizOperacion.SumarMatrices(matriz1, matriz2);

                // Muestra el resultado en el DataGridView
                dataGridView1.RowCount = 4;
                dataGridView1.ColumnCount = 4;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        dataGridView1[j, i].Value = resultado[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Ambas matrices deben estar completas antes de realizar la suma.");
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
