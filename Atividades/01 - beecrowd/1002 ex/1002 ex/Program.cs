namespace exercicio1002
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double n = 3.14159;
            double r = double.Parse (Console.ReadLine());
            double R = (r * r);
            double A = n * R;

            Console.WriteLine($"A={A:F4}");

        }
    }
}