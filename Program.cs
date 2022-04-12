using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* D5 */
            // Sorteando número
            int sorteio = new Random().Next(1, 5);
            int tentativa = 10;

            // Validando se acertou o chute
            string pegaChute(int chuteDoUsuario)
            {
                return chuteDoUsuario == sorteio ? "\nParabéns, você acertou!!!" : "\ninfelizmente não foi dessa vez";
            }

            // Saudação
            Console.WriteLine("Bem-vindo ao acerte o D5 - Offline");
            bool jogoAtivo = true;

            while (jogoAtivo)
            {
                do
                {
                    string Menu = "\nEscolha um valor de 1 a 10 e direi se você acertou, você tem " + tentativa + " tentativa";

                    if (tentativa > 1)
                    {
                        Console.WriteLine(Menu + "s");
                    }
                    else
                    {
                        Console.WriteLine(Menu);
                    }

                    // Recebendo chute
                    int chute = int.Parse(Console.ReadLine());

                    string resultado = pegaChute(chute);
                    Console.WriteLine(resultado);
                    if (resultado == "Parabéns, você acertou!!!")
                    {
                        tentativa = 0;
                    }
                    else
                    {
                        tentativa--;
                    }
                } while (tentativa > 0);

                Console.WriteLine("Deseja continuar?(s/n)");
                string desejaContinuar = Console.ReadLine();
                if (desejaContinuar == "n")
                {
                    jogoAtivo = false;

                }
                else
                {
                    tentativa = 10;
                }
            }
        }
    }
}
