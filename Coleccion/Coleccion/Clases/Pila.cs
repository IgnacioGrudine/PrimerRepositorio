using Coleccion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion.Clases
{
    public class Pila : ColeccionAbstracta
    {
        public Pila(int tamaño) : base(tamaño) { }

        public override object extraer()
        {
            if (estaVacia())
            {
                Console.WriteLine("La pila está vacía.");
                return null;
            }
            object temp = array[contador];
            array[contador] = null;
            contador--;
            return temp;
        }
    }
}
