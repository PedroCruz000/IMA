namespace matrizes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de linhas e colunas: ");
            string[] input = Console.ReadLine().Split();
            int nLinhas = int.Parse(input[0]);
            int nColunas = int.Parse(input[1]);

            Console.WriteLine($"linhas = {nLinhas}");
            Console.WriteLine($"colunas = {nColunas}");

            int[,] Matriz = new int[nLinhas, nColunas];

            for (int i = 0; i < nLinhas; i++)
            {
                //lendo linhas 
                input = Console.ReadLine().Split();

                for(int j = 0; j < nColunas; j++)
                {
                    // quebrando a linha pelas colunas da matriz
                    Matriz[i,j] = int.Parse(input[j]);
                }
            }
            for (int i = 0; i < nLinhas; i++)
            {
                for(int j = 0; j< nColunas; j++)
                {
                    Console.Write(Matriz[i,j] + " ");

                }
                Console.WriteLine();
            }
            

           Console.WriteLine($"a quantidade de linhas é {nLinhas} e a quantidade de colunas é {nColunas}");

        }
    }
}