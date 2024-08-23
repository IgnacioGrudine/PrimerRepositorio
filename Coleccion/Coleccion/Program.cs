using Coleccion.Clases;
using Coleccion.Interfaces;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa el tamaño de la colección");
        int tamaño = int.Parse(Console.ReadLine());
        var pila = new Pila(tamaño);
        var cola = new Cola(tamaño);

        ColeccionAbstracta[] arreglo = { pila, cola };

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("ELIJA UNA OPCIÓN");
            Console.WriteLine("1. AÑADIR UN NUEVO ELEMENTO");
            Console.WriteLine("2. ESTÁ VACÍA");
            Console.WriteLine("3. EXTRAER");
            Console.WriteLine("4. PRIMERO");
            Console.WriteLine("5. SALIR");
            string opcion = Console.ReadLine();

            foreach (ColeccionAbstracta c in arreglo)
            {
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Escriba un elemento para ingresar:");
                        object elemento = Console.ReadLine();
                        if (c.añadir(elemento))
                        {
                            Console.WriteLine($"Se cargó el elemento: {elemento}");
                        }
                        else
                        {
                            Console.WriteLine("La colección está llena.");
                        }
                        break;

                    case "2":
                        if (c.estaVacia())
                        {
                            Console.WriteLine("La colección se encuentra vacía.");
                        }
                        else
                        {
                            Console.WriteLine("La colección tiene elementos.");
                        }
                        break;

                    case "3":
                        object extraido = c.extraer();
                        if (extraido != null)
                        {
                            Console.WriteLine($"Se extrajo el elemento: {extraido}");
                        }
                        break;

                    case "4":
                        object primero = c.primero();
                        if (primero != null)
                        {
                            Console.WriteLine($"El primer elemento es: {primero}");
                        }
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}

