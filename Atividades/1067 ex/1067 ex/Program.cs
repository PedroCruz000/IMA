namespace ex1067
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());


            for (int count = 10; count <= x; count++)
                if (count %2 != 0)
                {
                    Console.WriteLine(count);
                }
            
         
        }
    }
}