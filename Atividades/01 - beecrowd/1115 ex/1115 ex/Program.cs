namespace ex1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                string linha = Console.ReadLine();
                string[] xy = linha.Split();

                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

               if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
               else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
               else if (x < 0 && y <0)
                {
                    Console.WriteLine("terceiro");
                }
               else if (x < 0 && y > 0 )
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    break;
                }
            }
        }
    }
}