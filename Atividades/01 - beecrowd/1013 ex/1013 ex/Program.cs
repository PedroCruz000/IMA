namespace ex1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split(' ');

            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]);
            int c = int.Parse(numeros[2]);

            int maior = (a + b + Math.Abs(a - b)) / 2;
            maior = (maior + c + Math.Abs(maior - c)) /2 ;

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}