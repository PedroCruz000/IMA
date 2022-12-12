namespace ex1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeRepetições = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroDeRepetições; i++)
            {
                string linha = Console.ReadLine();
                string[] xy = linha.Split();

                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                if (y ==0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisão = (double)x / y;
                    Console.WriteLine($"{divisão:f1}");
                    
                }
                
                
            }
            
        }
    }
}