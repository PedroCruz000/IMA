namespace ex1043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numerosABC = linha.Split();

            double reta1 = double.Parse(numerosABC[0]);
            double reta2 = double.Parse(numerosABC[1]);
            double reta3 = double.Parse(numerosABC[2]);
            double perimetro = reta1 + reta2 + reta3;
            double areaDoTrapezio = ((reta1 + reta2) * reta3) / 2;

            if (reta1 < reta2 + reta3 && reta2 < reta1 + reta3 && reta3 < reta1 + reta2)
            {
                Console.WriteLine($"Perimetro = {perimetro:f1}");
            }
            else
            {
                Console.WriteLine($"Area = {areaDoTrapezio:f1}");
            }
            
        }
    }
}