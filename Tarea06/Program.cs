using System;

namespace Tarea06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("\n1.Registrar persona" +
                    "\n2.Buscar persona" +
                    "\n3.Salir");

                salir = ejecutarSeleccion(seleccionarOpcion());
            } while (!salir);
        }

        public static int seleccionarOpcion()
        {
            Console.Write("\nSeleccione su opción: ");
            int.TryParse(Console.ReadLine(), out int opcion);
            Console.WriteLine("\n");

            return opcion;
        }

        public static bool ejecutarSeleccion(int opcion)
        {
            bool salir = false;

            switch (opcion)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            return salir;
        }
    }
}