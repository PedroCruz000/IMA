namespace ex1009
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendaFeita = double.Parse(Console.ReadLine());

            double comição = .15 * vendaFeita;
            double salarioFinal = comição + salarioFixo;
            Console.WriteLine($"TOTAL = R$ {salarioFinal:f2}");
        }
    }
}