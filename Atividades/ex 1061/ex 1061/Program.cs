namespace ex1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numerosPositivos = 0;
            int contador = 0;
            double somaDosNumerosPositivos = 0;

            while (contador <= 5)
            {
                contador++;
                double numeros = double.Parse(Console.ReadLine());
                if (numeros > 0)
                {
                    somaDosNumerosPositivos+= numeros;
                    
                    numerosPositivos++;
                }

            }

            double media = somaDosNumerosPositivos / numerosPositivos;
            Console.WriteLine($"{numerosPositivos} valores positivos");
            Console.WriteLine($"{media:f1}");

        }
    }
}
