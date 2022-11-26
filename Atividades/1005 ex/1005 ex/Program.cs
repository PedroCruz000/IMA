namespace exercicio1050
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double somaMedia = (n1 * 3.5) + (n2 * 7.5);
            double media = somaMedia / 11;

            Console.WriteLine($"MEDIA = {media:f5}");

        }
    }
}