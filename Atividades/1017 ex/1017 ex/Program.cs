namespace ex1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tempoDeViagem = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double distancia = tempoDeViagem * velocidadeMedia;
            double altonomia = distancia / 12;

            Console.WriteLine($"{altonomia:f3}");
        }
    }
}