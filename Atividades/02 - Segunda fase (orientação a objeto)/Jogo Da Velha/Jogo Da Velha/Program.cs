using System.Numerics;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];

            string turno = "X";
            int tentativas = 1;
            

            //lista para adicionar as jogadas feitas, e não deixar o usuario repetilas 
            List<string> indexNumeros = new List<string>();

            int index = 1;


            Console.WriteLine("------------------------------");
            Console.WriteLine("--BEM VINDO AO JOGO DA VELHA--");
            Console.WriteLine("------------------------------");

            // Alimentando a Matriz

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = index.ToString(); 
                    indexNumeros.Add(index.ToString());
                    index++;    
                }
            }


            //imprimindo a matriz

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($"[{matriz[linha,coluna]}]");
                }
                Console.WriteLine();

            }
            Console.WriteLine("");
            Console.Write("Digite a posição da sua jogada: ");
            string jogada = Console.ReadLine();

            //rodadas

            Console.Clear();


            // começa o jogo 

            
            while(tentativas < 9) {

                if (turno == "X")
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("------ VEZ DO JOGADOR O ------");
                    Console.WriteLine("------------------------------");
                }
                else
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("------ VEZ DO JOGADOR X ------");
                    Console.WriteLine("------------------------------");
                }

                

                // Subistituir numero da matriz 

                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        if (matriz[linha,coluna] == jogada && indexNumeros.Contains(jogada))
                        {
                            matriz[linha, coluna] = turno;
                            indexNumeros.Remove(jogada);
                        }
                    }
                }


                // reescrever a matriz 

                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                    {
                        Console.Write($"[{matriz[linha, coluna]}]");
                    }
                    Console.WriteLine();

                }

                //condição de vitoria 

                // vitoria nas diagonais 

                if (matriz[0,0] == matriz[1,1] && matriz[0,0] == matriz[2,2] ||
                    matriz[0,2] == matriz[1,1] && matriz[0,2] == matriz[2,0])
                {

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O JOGADOR:----{turno}---- VENCEU ");
                    Console.ResetColor();
                    break;
                }

                //vitoria nas horizontais 

                if (matriz[0,0] == matriz[0,1] && matriz[0,0] == matriz[0,2]||
                    matriz[1,0] == matriz[1,1] && matriz[1,0] == matriz[1,2]||
                    matriz[2,0] == matriz[2,1] && matriz[2,0] == matriz[2,2])
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O JOGADOR:----{turno}---- VENCEU ");
                    Console.ResetColor();
                    break;
                } 

                //vitorias nas verticais 

                if (matriz[0,0] == matriz[1,0] && matriz[0,0] == matriz[2,0]||
                    matriz[0,1] == matriz[1,1] && matriz[0,1] == matriz[2,1]||
                    matriz[0,2] == matriz[1,2] && matriz[0,2] == matriz[2,2])
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O JOGADOR:----{turno}---- VENCEU ");
                    Console.ResetColor();
                    break;
                }

                // escrever a proxima jogada 

                Console.WriteLine("");
                Console.Write("Digite a posição da sua jogada: ");
                jogada = Console.ReadLine();

                if (turno == "X")
                {
                    
                    turno = "O";
                    
                }
                else
                {
                    turno = "X";
                }


                //erro caso digite uma tecla errada 

                while (!indexNumeros.Contains(jogada))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Jogada invalida. Tente Novamente");
                    Console.ResetColor();

                    jogada = Console.ReadLine();
                }

                tentativas++;

                if (tentativas == 9)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"-------DEU VELHA-------");
                    Console.WriteLine($"-----NINGUÉM VENCEU----");
                    Console.ResetColor();
                    break;
                    

                }

                Console.Clear() ;

                
            }

            



        }
    }
}
