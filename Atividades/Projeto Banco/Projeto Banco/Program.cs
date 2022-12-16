namespace projetoBanco
{
    public class Program
    {
        static double Somar(double numero1, double numero2)
        {
            double soma = numero1 + numero2;

            return soma;
        }

        static void DizerOla(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }

        static void DizerOlaEResponderSoma(string nome, double numero1, double numero2)
        {
            DizerOla(nome);
            Console.WriteLine($" O valor da sua soma é {Somar(numero1, numero2)}");
        }
        public static void Main(string[] args)
        {
            Console.Write(" olá, qual o seu nome:");
            string nome = Console.ReadLine();

            Console.Write("Digite um numero:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro valor:");
            double numero2 = double.Parse(Console.ReadLine());


            DizerOlaEResponderSoma(nome, numero1, numero2);


        } 
    }
}