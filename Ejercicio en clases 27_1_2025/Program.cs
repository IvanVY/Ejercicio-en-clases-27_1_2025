using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clases_27_1_2025
{
    internal class Program
    {
        private static int vidasUsuario = 3;
        private static int vidasPc = 3;
        static void Main(string[] args)
        {
            ejercicio();
        }

        private static void ejercicio()
        {
            do
            {

                int opcionJugador = menuOpciones();
                int random = new Random().Next(1, 4);
                logicaJuego(opcionJugador, random);

                mostrarGanador();
                if (vidasUsuario == 0 || vidasPc == 0)
                {
                    Console.WriteLine("Quieres jugar de nuevo? (s/n): ");
                    if (Console.ReadLine().ToLower().Equals("n")) break;
                    vidasUsuario = vidasPc = 3;

                } 
            } while (true);
        }
        private static int menuOpciones()
        {
            Console.WriteLine("1.. Piedra, 2.. Papel, 3.. Tijera");
            return int.Parse(Console.ReadLine());
        }

        private static void logicaJuego(int a, int b)
        {
            

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
            else if (a==b)
            {
                Console.WriteLine("Empate");
                
            }
            else
            {
                Console.WriteLine("Perdiste");
                vidasUsuario--;
                cadena = $"Pc gana, te quedan {vidasUsuario} vidas";
            }

            if (vidasPc == 0)
            {
                Console.WriteLine("Pc se quedo sin vidas, tu eres el ganador");
                
            }else if(vidasUsuario == 0)
            {
                Console.WriteLine("Te quedaste sin vidas, pc es el ganador");
            }
            Console.WriteLine(cadena);

        }

        private static void mostrarGanador()
        {
            if (vidasPc == 0)
            {
                Console.WriteLine("Pc se quedo sin vidas, tu eres el ganador");
            }
            else if (vidasUsuario == 0)
            {
                Console.WriteLine("Te quedaste sin vidas, pc es el ganador");
            }
            
        }
    }
}
