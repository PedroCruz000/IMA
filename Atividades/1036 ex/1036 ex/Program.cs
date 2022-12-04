namespace ex1036
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string[] numeros = linha1.Split();

            double A = double.Parse(numeros[0]);
            double B = double.Parse(numeros[1]);
            double C = double.Parse(numeros[2]);

            double delta = (Math.Pow(B, 2)) - (4 * A * C);
            double R1 = (-B + (Math.Sqrt(delta))) / (2 * A);
            double R2 = (-B - (Math.Sqrt(delta))) / (2 * A);

            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine($"R1 = {R1:f5}");
                Console.WriteLine($"R2 = {R2:f5}");
            }


           

           // Console.WriteLine(R1);
           //Console.WriteLine(R2);  

        }
    }
}