namespace ex1043
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numerosABC = linha.Split();

            double A = double.Parse(numerosABC[0]);
            double B = double.Parse(numerosABC[1]);
            double C = double.Parse(numerosABC[2]);


            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);   
        }
    }
}