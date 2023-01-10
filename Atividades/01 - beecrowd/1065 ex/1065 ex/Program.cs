namespace ex1065
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numerosPares = 0;
            int contador = 0;

            while (contador <= 4)
            {
                
                int numeros = int.Parse(Console.ReadLine());
                if (numeros %2 == 0)
                {
                    numerosPares++;
                }
                    
                contador++;
            }
            Console.WriteLine($"{numerosPares} valores pares");
        } 
     }
}