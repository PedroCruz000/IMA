using System.Xml.Schema;

namespace ex1094
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeRepetições = int.Parse(Console.ReadLine());

            int coelho = 0; 
            int rato = 0;  
            int sapo = 0;

            for (int cont = 0; cont <numeroDeRepetições; cont++)
            {
                string linha = Console.ReadLine();
                string[] amountType = linha.Split();

                int quantidadeDeAnimais = int.Parse(amountType[0]);
                string tipoDoAnimal = (amountType[1]);

                if (tipoDoAnimal == "C")
                {
                    coelho = coelho + quantidadeDeAnimais;
                }

                else if (tipoDoAnimal == "R")
                {
                    rato = rato + quantidadeDeAnimais;
                }

                else if (tipoDoAnimal == "S")
                {
                    sapo = sapo+ quantidadeDeAnimais;
                }

            }
            
            double percentualCoelho = ((double)coelho * 100) / (coelho + rato + sapo);
            double percentualRato = ((double)rato * 100) / (coelho + rato + sapo);
            double percentualSapo = ((double)sapo * 100) / (coelho + rato + sapo);


            Console.WriteLine($"Total: {coelho + rato + sapo} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelho:f2} %");
            Console.WriteLine($"Percentual de ratos: {percentualRato:f2} %");
            Console.WriteLine($"Percentual de sapos: {percentualSapo:f2} %");
            
        }
    }
}