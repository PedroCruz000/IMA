using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Teste.inicio
{
    public class Menu
    {
        public static void Abertura()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tBem-vindo(a) ao Jogo da Velha.");
            Console.Write("\n\tPressione qualquer tecla para acessar ao menu ");
            Console.ReadKey();
            Console.ResetColor();

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

    }
}
