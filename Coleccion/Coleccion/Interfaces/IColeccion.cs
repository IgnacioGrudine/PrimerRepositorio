using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion.Interfaces
{
    public interface IColeccion
    {
        bool estaVacia();
        object extraer();

        object primero();
        bool añadir(object objeto);
    }
}
