namespace ex1014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quilometrosPercorridos = int.Parse(Console.ReadLine()); 
            float combustivelGasto =  float.Parse(Console.ReadLine());    

            double mediaDeConsumo = quilometrosPercorridos / combustivelGasto;

            Console.WriteLine($"{mediaDeConsumo:f3} km/l");
        }
    }
}