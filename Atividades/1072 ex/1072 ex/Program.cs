namespace ex1072{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeRepetiçoes = int.Parse(Console.ReadLine());
            int dentroDoIntervalo = 0;
            int foraDoIntervalo = 0;
            
            for (int cont=0; cont < numeroDeRepetiçoes; cont++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentroDoIntervalo += 1;
                }
                else
                {
                    foraDoIntervalo += 1;
                }
                
            }
            Console.WriteLine($"{dentroDoIntervalo} in");
            Console.WriteLine($"{foraDoIntervalo} out");
        }
    }
}