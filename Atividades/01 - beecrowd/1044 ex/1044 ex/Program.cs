namespace ex1044
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split();

            int numero1 = int.Parse(numeros[0]);
            int numero2 = int.Parse(numeros[1]);           
            int menor = Math.Min(numero1, numero2);
            int maior = Math.Max(numero1, numero2);
            int multiplos = maior % menor;

            if ( multiplos == 0 )
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}