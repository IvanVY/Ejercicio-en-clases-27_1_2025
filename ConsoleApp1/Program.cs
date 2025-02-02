using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 - Cálculo de área del círculo
            Console.WriteLine("Calcula el área de un círculo:");
            Console.WriteLine("Ingrese el radio:");
            float radio = float.Parse(Console.ReadLine());
            double area = CalcularAreaCirculo(radio);
            Console.WriteLine($"El área del círculo es: {area}");

            // Ejercicio 2 - Suma de números
            int sumaTotal = 0;
            int numeroIngresado;
            do
            {
                Console.WriteLine("Ingrese un número (o ingrese -1 para salir):");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (numeroIngresado == -1)
                    {
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    }
                    sumaTotal += numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

            } while (true);

            Console.WriteLine($"La suma total es: {sumaTotal}");
        }

        static double CalcularAreaCirculo(float radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}