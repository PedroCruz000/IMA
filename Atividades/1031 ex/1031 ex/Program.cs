namespace ex1131
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totalVitorisInter = 0;
            int totalVitoriasGremio = 0;
            int totalDeEmpates = 0;
            int numeroDeGrenais = 0;
            while(true)
            {
                string linha = Console.ReadLine();
                string[] golsInterEGremio = linha.Split();
                
                int golInter = int.Parse(golsInterEGremio[0]);
                int golGremio = int.Parse((golsInterEGremio[1]));

                if (golInter > golGremio)
                {
                    totalVitorisInter++;
                }
                else if (golInter < golGremio)
                {
                    totalVitoriasGremio++;
                }
                else
                {
                    totalDeEmpates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int continuar = int.Parse(Console.ReadLine());

                numeroDeGrenais++;

                if (continuar ==2 )
                {
                    Console.WriteLine($"{numeroDeGrenais} grenais");
                    Console.WriteLine($"Inter:{totalVitorisInter}");
                    Console.WriteLine($"Gremio:{totalVitoriasGremio}");
                    Console.WriteLine($"Empates:{totalDeEmpates}");
                    if (totalVitorisInter > totalVitoriasGremio)
                    {
                        Console.WriteLine("Inter venceu mais");
                    }
                    else if (totalVitorisInter < totalVitoriasGremio)
                    {
                        Console.WriteLine("Gremio venceu mais");
                    }
                    else
                    {
                        Console.WriteLine("Não houve vencedor");
                    }
                    break;
                }
              


            }
           

        }
    }
}