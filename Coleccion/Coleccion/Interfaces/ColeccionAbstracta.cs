using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion.Interfaces
{
    public  abstract class ColeccionAbstracta : IColeccion
    {
        public object[] array;
        public int contador;
        

        public ColeccionAbstracta(int tamaño)
        {
            array = new object[tamaño];
            contador = -1;
        }
        public bool añadir(object objeto)
        {
             
           if(contador >= array.Length -1)
            {
                return false;
            }
            contador++;
            array[contador] = objeto;
            return true;    
        }

        public bool estaVacia()
        {
            if(contador == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract object extraer();
        

        public object primero()
        {
            if (estaVacia())
            {
                Console.WriteLine("La pila esta vacia.");
                return null;
            }

            return array[0];
        }
    }
}
