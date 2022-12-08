namespace ex1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int numeroDeVezesContadas = 0;
            
            for (int count = x; numeroDeVezesContadas <= 5; count++)
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                    numeroDeVezesContadas++;
                }
            
        }
    }
}