namespace ex1095
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int j = 60;

            for (int cont = 0; j >= 0; j -= 5)
            {
                Console.WriteLine($"I={i} J={j}");
                i += 3;
            }
        }
    }
}