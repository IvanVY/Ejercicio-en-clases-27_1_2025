using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clases_27_1_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int opcionJugador = menuOpciones();
                int random = new Random().Next(1, 4);
                logicaJuego(opcionJugador, random);

            } while (true);
        }

        private static int menuOpciones()
        {
            Console.WriteLine("1.. Piedra, 2.. Papel, 3.. Tijera, 0 para salor ");
            return int.Parse(Console.ReadLine());
        }

        private static void logicaJuego(int a, int b)
        {
            int vidasUsuario = 3;
            int vidasPc = 3;
            String cadena = "";
            string[] opciones = {"Piedra", "Papel", "Tijera"};
            Console.WriteLine($"Usuario: {opciones[a - 1]} vs Pc: {opciones[b - 1]}");
            //piedra papel tijera usuario a 1->piedra  2->papel  3->tijera
            //piedra papel tijera pc b      3->tijera  1->piedra 2->papel
            if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
            {
                Console.WriteLine("Ganaste");
                vidasPc--;
                cadena = $"Usuario gana, al pc le quedan {vidasPc}";
            }
            else if ((b == 1 && a == 3) || (b == 2 && a == 1) || (b == 3 && a == 2))
            {
                Console.WriteLine("Perdiste");
                vidasUsuario--;
                cadena = $"Pc gana, te quedan {vidasUsuario} vidas";
            }
            else
            {
                Console.WriteLine("Empate");
            }

            Console.WriteLine(cadena);




            /*static string eleccionJugador()
            {
                //solicitar al jugador que elija una opcion
                Console.WriteLine("1 (Piedra), 2 (Papel), 3 (Tijera)");
                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        return "Piedra";
                    case 2:
                        return "Papel";
                    case 3:
                        return "Tijera";
                    default:
                        Console.WriteLine("Opcion no valida");

                        return eleccionJugador();
                }
            }

            //Funcion para generar la eleccion de la computadora
            static string eleccionComputadora()
            {
                //Generar un numero aleatorio entre 1 y 3
                Random random = new Random();
                int eleccion = random.Next(1, 4);

                switch (eleccion)
                {
                    case 1:
                        return "Piedra";
                    case 2:
                        return "Papel";
                    case 3:
                        return "Tijera";
                    default:
                        return "Piedra";
                }
            }

            //funcion para determinar el resultado del juego
            static void ganador(string jugador, string computadora)
            {
                //mostrar las elecciones del jugador y computador
                Console.WriteLine($"Elegiste: {jugador}");
                Console.WriteLine($"Computadora eligio: {computadora}");
                //Determinar el ganador
                if (jugador == computadora)
                {
                    Console.WriteLine("Empate");
                }
                else if (jugador == "Piedra" && computadora == "Tijera" ||
                         jugador == "Papel" && computadora == "Piedra" ||
                         jugador == "Tijera" && computadora == "Papel")
                {
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    Console.WriteLine("Perdiste");
                }
            }*/

        }
    }
}
