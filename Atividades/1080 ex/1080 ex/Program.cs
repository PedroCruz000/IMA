namespace ex1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = 0;
            int posição = 0;
            for (int cont = 0; cont < 100; cont++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posição = cont;

                }
                Console.WriteLine(maior);
                Console.WriteLine(posição+1);
            }
        }
    }
}