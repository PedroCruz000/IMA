namespace ex1079
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < casosDeTeste; cont++)
            {

                string linha1 = Console.ReadLine();
                string[] numeros = linha1.Split();

                double n1 = double.Parse(numeros[0]);
                double n2 = double.Parse(numeros[1]);
                double n3 = double.Parse(numeros[2]);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                
                Console.WriteLine($"{media:f1}");

            }



            
        }
    }
}