namespace ex1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numerosXY = linha.Split();

            double eixoX = double.Parse(numerosXY[0]);
            double eixoY = double.Parse(numerosXY[1]);

           if (eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
           else if (eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
           else if (eixoX <0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
           else if (eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}