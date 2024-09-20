using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rango_de_numeros.models
{
    public class NumberRange
    {
        public int X { get; set; }
        public int Y { get; set; }

        public NumberRange(int x, int y)
        {
            X = x;
            Y = y;
        }

        public List<int> ObtenerRango()
        {
            List<int> numeros = new List<int>();

            if (X <= Y)
            {
                for (int i = X; i <= Y; i++)
                {
                    numeros.Add(i);
                }
            }
            else
            {
                for (int i = X; i >= Y; i--)
                {
                    numeros.Add(i);
                }
            }

            return numeros;
        }

    }
}
