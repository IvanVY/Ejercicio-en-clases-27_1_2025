using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // Variable global de tipo int
        static int sumaTotal = 0;

        // Función que recibe un número entero y lo suma a sumaTotal
        static void AgregarNumero(int numero)
        {
            sumaTotal += numero;
        }
        static void Main(string[] args)
        {
            // Llamamos a la función AgregarNumero con diferentes valores
            AgregarNumero(10);
            AgregarNumero(5);
            AgregarNumero(3);

            // Mostramos el resultado de sumaTotal
            Console.WriteLine("El total de la suma es: " + sumaTotal);
        }

        
    }
}
