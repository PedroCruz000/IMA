namespace projetoBanco
{
    public class Program
    {
        //função somar 
        static double Somar(double numero1, double numero2)
        {
            double soma = numero1 + numero2;

            return soma;
        }
        /*função dizer olá */
        static void DizerOla(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }

        //função dizer olá e somar 
        static void DizerOlaEResponderSoma(string nome, double numero1, double numero2)
        {
            DizerOla(nome);
            Console.WriteLine($" O valor da sua soma é {Somar(numero1, numero2)}");
        }

        //programa interagindo com o usuário 
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