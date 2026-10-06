using System;

namespace Caso4
{
    internal class Program
    {
        static int edad;
        static string entrada = "";

        static void SolicitarDatos()
        {
            Console.Write("Ingrese la edad: ");

            while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
            {
                Console.Write("Edad incorrecta. Ingrese nuevamente: ");
            }

            Console.Write("¿Tiene entrada válida? (si/no): ");
            entrada = Console.ReadLine();
        }

        static bool PuedeIngresar()
        {
            if (edad >= 18 && entrada == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MostrarResultado()
        {
            if (PuedeIngresar())
            {
                Console.WriteLine("Puede ingresar a la actividad.");
            }
            else
            {
                Console.WriteLine("No puede ingresar a la actividad.");
            }
        }

        static void Main(string[] args)
        {
            SolicitarDatos();
            MostrarResultado();

            Console.ReadKey();
        }
    }
}

