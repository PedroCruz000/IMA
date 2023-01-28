using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste02.Services
{
    public class Jogar
    {
        private static string Jogador1;
        private static string Jogador2;

        private static int Tamanho;
        private static List<string> posicoes = new List<string>() ;


        public static void SelecionarJogadores()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\tJogador 1: ");
            Console.ResetColor();

            //pedir para o usuario escolher o jogador pelo nome:
            string jogador1 = Console.ReadLine();

            //validar se o jogador existe 
            jogador1 = Menu.NaoExisteJogador(jogador1);

            // adicionar o jogador 1 ao nome do jogador 
            Jogador1 = jogador1;

            //repetir o processo para o jogador 02 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\tJogador 2: ");
            Console.ResetColor();
            string jogador2 = Console.ReadLine();
            jogador2 = Menu.NaoExisteJogador(jogador2);
            Jogador2 = jogador2;
        }

















     

        
    }
}
