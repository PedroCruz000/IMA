namespace ex1113
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                string linha = Console.ReadLine();
                string[] XY = linha.Split();

                int x = int.Parse(XY[0]);
                int y = int.Parse(XY[1]);

                if (x == y)
                {
                    break;
                }
                else if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

               
            }
        }
    }
}