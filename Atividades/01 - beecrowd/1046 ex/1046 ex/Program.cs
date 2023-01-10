namespace ex1046
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split();

            int horarioDeInicio = int.Parse(numeros[0]);
            int horarioDoTermino = int.Parse(numeros[1]);
            int duração;

            if (horarioDeInicio > horarioDoTermino)
            {
                duração = horarioDoTermino + 24 - horarioDeInicio;
                Console.WriteLine($"O JOGO DUROU {duração} HORA(S)");
            }
            else if (horarioDeInicio == horarioDoTermino)
            {
                duração = 24;
                Console.WriteLine($"O JOGO DUROU {duração} HORAS(S)");
            }
            else if(horarioDeInicio < horarioDoTermino)
            {
                duração = horarioDoTermino - horarioDeInicio;
                Console.WriteLine($"O JOGO DUROU {duração} HORAS(S)");
            }
        }
    }
}