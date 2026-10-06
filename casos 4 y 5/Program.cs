using System;

namespace Caso5
{
    internal class Program
    {
        static int disponible;
        static int cantidadVenta;

        static void SolicitarDatos()
        {
            Console.Write("Ingrese la cantidad disponible: ");

            while (!int.TryParse(Console.ReadLine(), out disponible) || disponible < 0)
            {
                Console.Write("Cantidad incorrecta. Ingrese nuevamente: ");
            }

            Console.Write("Ingrese la cantidad que desea vender: ");

            while (!int.TryParse(Console.ReadLine(), out cantidadVenta) || cantidadVenta <= 0)
            {
                Console.Write("Cantidad incorrecta. Ingrese nuevamente: ");
            }
        }

        static bool PuedeVender()
        {
            if (cantidadVenta <= disponible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void RealizarVenta()
        {
            if (PuedeVender())
            {
                disponible = disponible - cantidadVenta;

                Console.WriteLine("Venta realizada correctamente.");
                Console.WriteLine("Cantidad restante: " + disponible);
            }
            else
            {
                Console.WriteLine("No hay suficiente inventario.");
                Console.WriteLine("Cantidad disponible: " + disponible);
            }
        }

        static void Main(string[] args)
        {
            SolicitarDatos();
            RealizarVenta();

            Console.ReadKey();
        }
    }
}
