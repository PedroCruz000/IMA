namespace ex1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;
            for (int cont = 1; cont <= 100; cont++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = cont;

                }
            }


            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}