namespace ex1011
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int raio = int.Parse(Console.ReadLine());
            double volume = (4.0 / 3) * 3.14159 * raio * raio * raio ;
            Console.WriteLine($"VOLUME = {volume:f3}");
        }
    }
}