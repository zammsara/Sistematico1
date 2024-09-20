using rango_de_numeros.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rango_de_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el ListBox antes de agregar nuevos números
                ltsNumbers.Items.Clear();

                // Obtener los valores de los controles NumericUpDown
                int x = (int)numX.Value;
                int y = (int)numY.Value;

                // Crear una instancia de la clase NumeroRango
                NumberRange rango = new NumberRange(x, y);

                // Obtener los números en el rango
                List<int> numeros = rango.ObtenerRango();

                // Mostrar los números en el ListBox
                foreach (int numero in numeros)
                {
                    ltsNumbers .Items.Add(numero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
