namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];

            string turno = "X";
            int tentativas = 0;
            

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
                        if (matriz[linha,coluna] == jogada)
                        {
                            matriz[linha, coluna] = turno; 
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

                tentativas++;
                Console.Clear() ;

                
            }

            



        }
    }
}
