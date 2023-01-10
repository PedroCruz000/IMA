namespace ex1066
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            int numerosPares = 0;
            int numerosImpares = 0;
            int numerosPositivos = 0; 
            int numerosNegativos = 0; 

            while(contador <= 4)
            {               
                int numero = int.Parse(Console.ReadLine());
                if (numero %2 == 0 )
                {
                    numerosPares++;
                }
                if (numero %2 != 0)
                {
                    numerosImpares++;

                }
                if (numero > 0)
                {
                    numerosPositivos++;

                }
                if (numero < 0 )
                {
                    numerosNegativos++;
                }
                contador++;
            }
            Console.WriteLine($"{numerosPares} valor(es) par(es)");
            Console.WriteLine($"{numerosImpares} valor(es) impar(es)");
            Console.WriteLine($"{numerosPositivos} valor(es) positivo(s)");
            Console.WriteLine($"{numerosNegativos} valor(es) negativo(s)");
        }

    }
}