using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste02.Repositorio;

namespace teste02
{
    internal class Menu
    {
        public static void Abertura()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tBem-vindo(a) ao Jogo da Velha.");
            Console.Write("\n\tPressione qualquer tecla para acessar ao menu ");
            Console.ReadKey();
            Console.ResetColor();
        }

        public static string PegarNome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\t Digite Seu Nome:");
            Console.ResetColor();
            string nome = Console.ReadLine();           
            return nome;
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\n\n\t 1 - Cadastrar jogador");
            Console.WriteLine("\n\t 2 - Deletar jogador");
            Console.WriteLine("\n\t 3 - Ranking dos jogadores");
            Console.WriteLine("\n\t 4 - Iniciar jogo da velha");
            Console.WriteLine("\n\t 0 - Sair");

            Console.ResetColor();
        }

        public static string ExisteJogador(string nome)
        {
            
            while (Json.jogadores.Any(player => player.Nome == nome))
            {
                Console.WriteLine("\n\tJogador já cadastrado. Tente novamente.");

                
                nome = PegarNome();
            }
            return nome;
        }
        public static string NaoExisteJogador(string nome)
        {
            while (!Json.jogadores.Any(player => player.Nome == nome))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t Jogador não cadastrado. Tente novamente.");
                Console.ResetColor();
                nome = PegarNome();
            }
            return nome;
        }

    }
}
