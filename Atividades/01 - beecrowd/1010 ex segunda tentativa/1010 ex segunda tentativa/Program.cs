namespace ex10102tetativa
{
    public class Program
    {
        public static void Main(string[] args) { 
        
            string produto1 = Console.ReadLine();
            string[] numeros1 = produto1.Split(' ');

            int codigoDoProduto1 = int.Parse(numeros1[0]);
            int numerosDeUnidadesDoProduto1 = int.Parse(numeros1[1]);
            double preçoDoProduto1 = double.Parse(numeros1[2]);



            string produto2 = Console.ReadLine();
            string[] numeros2 = produto2.Split(' ');

            int codigoDoProduto2 = int.Parse(numeros2[0]);
            int numeroDeUnidadesDoProduto2 = int.Parse(numeros2[1]);
            double preçoDoProduto2 = double.Parse(numeros2[2]);


            double totalProduto1 = numerosDeUnidadesDoProduto1 * preçoDoProduto1;
            double totalProduto2 = numeroDeUnidadesDoProduto2 * preçoDoProduto2;
            double totalGeral = totalProduto1 + totalProduto2;


            Console.WriteLine($"VALOR A PAGAR: R$ {totalGeral:f2}");
            //Console.WriteLine($"{codigoDoProduto1}\n {numerosDeUnidadesDoProduto1}\n {preçoDoProduto1} \n o total a pagar do produto 1 é {totalProduto1}\n o total a pagar do produto 2 é : {totalProduto2}\n fechando a conta com {totalGeral} ");
        }
    }
}