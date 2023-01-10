namespace ex1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split();

            int horaInicial = int.Parse(numeros[0]);
            int minutoInicial = int.Parse(numeros[1]);
            int horaFinal = int.Parse(numeros[2]);
            int minutoFinal = int.Parse(numeros[3]);

            int totalMinutosInicial, totalMinutosFinal,duraçãoEmHoras, duraçãoEmMinutos;


            // conversão de tudo para minutos 

            totalMinutosInicial = (horaInicial * 60) + minutoInicial;
            totalMinutosFinal = (horaFinal * 60) + minutoFinal;
           
          
            if ( totalMinutosInicial < totalMinutosFinal)
            {
                
                int duraçãoTotalEmMinutos = totalMinutosFinal - totalMinutosInicial;

                //conversão da quantidade de minutos para horas e minutos 

                duraçãoEmHoras = duraçãoTotalEmMinutos / 60;
                duraçãoEmMinutos = duraçãoTotalEmMinutos % 60;

                Console.WriteLine($"O JOGO DUROU {duraçãoEmHoras} HORA(S) E {duraçãoEmMinutos} MINUTO(S)");
                
            }
            else if (totalMinutosInicial == totalMinutosFinal)
            {
                duraçãoEmHoras = 24;
                duraçãoEmMinutos = 0;
                Console.WriteLine($"O JOGO DUROU {duraçãoEmHoras} HORA(S) E {duraçãoEmMinutos} MINUTO(S)");

            }
            else if ( totalMinutosInicial > totalMinutosFinal)
            {
                int duraçãoEmMinutos2 = (totalMinutosFinal + 1440) - totalMinutosInicial;

                duraçãoEmHoras = duraçãoEmMinutos2 / 60;
                duraçãoEmMinutos = duraçãoEmMinutos2% 60;
                Console.WriteLine($"O JOGO DUROU {duraçãoEmHoras} HORA(S) E {duraçãoEmMinutos} MINUTO(S)");
            }

        }
    }
}