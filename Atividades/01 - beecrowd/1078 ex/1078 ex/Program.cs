namespace ex1078
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int multiplicador = int.Parse(Console.ReadLine());
            for (int cont = 1; cont <11 ; cont++)
            {
                Console.WriteLine($"{cont} x {multiplicador} = {cont*multiplicador}");
            }
        }
    }
}