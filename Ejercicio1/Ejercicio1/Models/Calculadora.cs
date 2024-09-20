using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Calculadora
    {
        // Método que realiza la operación
        public double Operar(double numero1, double numero2, char operacion)
        {
            double resultado = 0;

            // Evaluar la operación
            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case 'x':
                case 'X': // También acepta 'X' mayúscula
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    // Verificar que no se divida por cero
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Error: No se puede dividir entre 0.");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Operación no válida.");
            }

            return resultado;
        }
    }
}
