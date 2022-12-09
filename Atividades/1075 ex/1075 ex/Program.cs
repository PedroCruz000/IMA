namespace ex1075
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroN = int.Parse(Console.ReadLine());

            for(int cont = 1; cont < 10000; cont++)
            {
                  
                if (cont % numeroN == 2)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
}