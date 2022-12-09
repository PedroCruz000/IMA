namespace ex1074
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeRepetições = int.Parse(Console.ReadLine());

            for (int cont = 0; cont <= numeroDeRepetições-1; cont++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x%2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x%2 != 0 && x< 0 )
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (x%2 == 0 && x > 0 )
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x%2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}