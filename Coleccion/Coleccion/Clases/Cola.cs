using Coleccion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion.Clases
{
    public class Cola : ColeccionAbstracta
    {
        private int frente;
        private int final;

        public Cola(int tamaño) : base(tamaño)
        {
            frente = 0;
            final = -1;
        }

        public override object extraer()
        {
            if (estaVacia())
            {
                Console.WriteLine("La cola está vacía.");
                return null;
            }
            object temp = array[frente];
            array[frente] = null;
            frente++;
            return temp;
        }

        public new bool añadir(object objeto)
        {
            if (final >= array.Length - 1)
            {
                return false; // No hay espacio disponible
            }
            final++;
            array[final] = objeto;
            return true;
        }
    }
}
