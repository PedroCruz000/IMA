using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste02.Entities
{

    public class Tabuleiro
    {
        public static string[,] GerarTabuleiro(int tamanho)
        {

            string[,] matriz = new string[tamanho, tamanho];
            int posicao = 1;
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    matriz[i, j] = posicao.ToString();
                    posicao++;
                }
            }
            return matriz;


        }

        public static void MostrarTabuleiro(string[,] tabuleiro, int tamanho)
        {
            int maior;
            string tab;
            if (tamanho == 3)
            {
                maior = 1;
                tab = "___|";
            }
            else if (tamanho < 10)
            {
                maior = 2;
                tab = "____|";
            }
            else
            {
                maior = 3;
                tab = "_____|";
            }
            string str = string.Concat(Enumerable.Repeat(tab, tamanho));
            str = str.Remove(str.Length - 1);
            Console.Clear();
            Console.WriteLine("\n");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("\t ");
                for (int j = 0; j < tamanho - 1; j++)
                {
                    if (tabuleiro[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" {0}", tabuleiro[i, j].ToString().PadLeft(maior));
                        Console.ResetColor();
                        Console.Write(" |");
                    }
                    else if (tabuleiro[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" {0}", tabuleiro[i, j].ToString().PadLeft(maior));
                        Console.ResetColor();
                        Console.Write(" |");
                    }
                    else Console.Write(" {0} |", tabuleiro[i, j].ToString().PadLeft(maior));
                }
                if (tabuleiro[i, tamanho - 1] == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" {0}\n", tabuleiro[i, tamanho - 1].ToString().PadLeft(maior));
                    Console.ResetColor();
                }
                else if (tabuleiro[i, tamanho - 1] == "O")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" {0}\n", tabuleiro[i, tamanho - 1].ToString().PadLeft(maior));
                    Console.ResetColor();
                }
                else Console.Write(" {0}\n", tabuleiro[i, tamanho - 1].ToString().PadLeft(maior));
                if (i != tamanho - 1) Console.WriteLine("\t {0}", str);
                else Console.WriteLine("\t {0}", str.Replace('_', ' '));
            }
        }
    }
}
