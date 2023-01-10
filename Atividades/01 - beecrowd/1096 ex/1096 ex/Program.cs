namespace ex1096
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int j = 7;
            for (int cont = 0; i <= 9; i += 2)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j--;
                Console.WriteLine($"I={i} J={j}");
                j += 2;
            }
        }
    }
}