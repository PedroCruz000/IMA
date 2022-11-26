namespace ex1007
{
    public class Program
    {
        public static void Main(string[] args) {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int resultado = (A*B) - (C*D);

            Console.WriteLine($"DIFERENÇA = {resultado}");

        }
    }
}