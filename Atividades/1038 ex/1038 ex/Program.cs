namespace ex1038
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string[] numeros = linha1.Split();

            int codigoDoProduto = int.Parse(numeros[0]);
            int quantidadeDeItens = int.Parse(numeros[1]);
            

            // cachorro quente 

            if (codigoDoProduto == 1)
            {
                double totalCachorroQuente = 4 * quantidadeDeItens;
                Console.WriteLine($"Total: R$ {totalCachorroQuente:f2}");
            }



            // x-salada

            else if (codigoDoProduto == 2)
            {
                double totalXSalada = 4.50 * quantidadeDeItens;
                Console.WriteLine($"Total: R$ {totalXSalada:f2}");
            }



            // X-Bacon

            else if (codigoDoProduto == 3)
            {
                double totalXBacon = 5 * quantidadeDeItens;
                Console.WriteLine($"Total: R$ {totalXBacon:f2}");
            }



            //Torrada Simples 

            else if (codigoDoProduto == 4)
            {
                double TotalTorradaSimples = 2 * quantidadeDeItens;
                Console.WriteLine($"Total: R$ {TotalTorradaSimples:f2}");
            }



            // Refrigerante 

            else if (codigoDoProduto == 5)
            {
                double totalRefrigerante = 1.50 * quantidadeDeItens;
                Console.WriteLine($"Total: R$ {totalRefrigerante:f2}");
            }

        }
    }
}