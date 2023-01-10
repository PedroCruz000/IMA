namespace ex1019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entradaSegundos = int.Parse(Console.ReadLine());

            int quantidadeHoras = entradaSegundos / 3600;
            int restoSegundos = entradaSegundos % 3600;

            int minutos = restoSegundos/ 60;
            int segundos = restoSegundos % 60;

         
            Console.WriteLine($"{quantidadeHoras}:{minutos}:{segundos}");
        }
    }
}