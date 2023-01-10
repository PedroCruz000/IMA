namespace ex1037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double numero1 = double.Parse(Console.ReadLine());

            if (numero1 >= 0 && numero1 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero1 > 25 && numero1 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero1 > 50 && numero1 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");

            }
           else if (numero1 > 75 && numero1 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");

            }
            else if (numero1 < 0 || numero1 > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}