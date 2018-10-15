using System;
using System.Collections.Generic;
using Tabla_Hash_Libreria;

namespace Tarea06
{
    public class Program
    {
        private static Gestor gestor;

        public static void Main(string[] args)
        {
            gestor = new Gestor();

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
                    registrarPersona();
                    break;

                case 2:
                    buscarPersona();
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

        public static void registrarPersona()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Cedula(sin espacios): ");
            int.TryParse(Console.ReadLine(), out int cedula);

            gestor.registarPersona(new Persona(cedula, nombre, apellido));
        }

        public static void buscarPersona()
        {
            Console.WriteLine("Mostar por \n1.Cedula \n2.Apellido");
            int opcion = seleccionarOpcion();

            switch (opcion)
            {
                case 1:
                    buscarPorCedula();
                    break;

                case 2:
                    buscarPorApellido();
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }

        public static void buscarPorCedula()
        {
            Console.Write("Numero cedula: ");
            int.TryParse(Console.ReadLine(), out int cedula);
            Persona persona = gestor.buscarPorCedula(cedula);

            if (persona != null)
            {
                Console.WriteLine("Nombre: " + persona.nombre + "\n" +
                    "Apellido: " + persona.apellido);
            }
            else
            {
                Console.WriteLine("Numero de cedula no encontrado");
            }
        }

        public static void buscarPorApellido()
        {
            Console.Write("Apellido: ");
            List<Persona> personasPorApellido = gestor.buscarPorApellido(Console.ReadLine());

            if (personasPorApellido != null)
            {
                foreach (Persona persona in personasPorApellido)
                {
                    Console.WriteLine("Nombre: " + persona.nombre + "\n" +
                                       "Apellido: " + persona.apellido);
                }
            }
            else
            {
                Console.WriteLine("No existen personas con el apellido");
            }
        }
    }
}