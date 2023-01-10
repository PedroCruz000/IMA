namespace ex1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numerosPositivos = 0;
            int contador = 0;
            

            while (contador <=5)
            {
                contador++;
                double numeros = double.Parse(Console.ReadLine());
                if (numeros >0 )
                {
                    numerosPositivos++;
                }
                
            }
            Console.WriteLine($"{numerosPositivos} valores positivos");
 
        }
    }
}
