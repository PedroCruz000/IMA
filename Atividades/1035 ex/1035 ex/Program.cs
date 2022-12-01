using System.Dynamic;

namespace ex1035
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string[] linha1Separada = linha1.Split();
            

            int A = int.Parse(linha1Separada[0]);
            int B = int.Parse(linha1Separada[1]);
            int C = int.Parse(linha1Separada[2]);
            int D = int.Parse(linha1Separada[3]);

            int somaCD = C + D;
            int somaAB = A + B;

            int aPar = A % 2;

            if (B > C)
            {
                if (D > A)
                {
                   if (somaCD > somaAB)
                    {
                        if (C > 0)
                        {
                            if (D > 0)
                            {
                                if(aPar == 0 )
                                {
                                    Console.WriteLine("Valores aceitos");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}