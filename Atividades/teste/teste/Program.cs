namespace teste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double teste = (double)4000 / 92;
            double resto = 4000 % 92;
            Console.WriteLine($"{teste:F2}");
            Console.WriteLine(resto);
        }
    }
}