namespace ex107
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int somaDosNumerosImpares = 0;
            
            if (x < y)
            {
            for (int count = x; count <= y; count++)
                {
                    //Console.WriteLine(count);
                    if (count % 2 !=0)
                    {
                        somaDosNumerosImpares = count + somaDosNumerosImpares;
                    }
                }
                       
            }
            else if (x > y)
            {
                for (int count = x-1; count >= y+1; count--)
                {
                    //Console.WriteLine(count);   
                    if (count % 2 != 0)
                    {
                        somaDosNumerosImpares = count + somaDosNumerosImpares;
                    }
                }
            }
            Console.WriteLine(somaDosNumerosImpares);
           

            
        }
    }
}