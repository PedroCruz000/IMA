using Microsoft.VisualBasic.FileIO;

namespace jogodavelhasempoo
{
    public class Program
    {

       //ABERTURA
         private static void Abertura()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tBem-vindo(a) ao Jogo da Velha.");
            Console.Write("\n\tPressione qualquer tecla para acessar ao menu ");
            Console.ReadKey();
            Console.ResetColor();
        }


        //MENU
         private static void Showmenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\n\n\t 1 - Cadastrar jogador");
            Console.WriteLine("\n\t 2 - Deletar jogador");
            Console.WriteLine("\n\t 3 - Ranking dos jogadores");
            Console.WriteLine("\n\t 4 - Iniciar jogo da velha");
            Console.WriteLine("\n\t 0 - Sair");

            Console.ResetColor();
        }

        //CADASTRAR JOGADOR









        //LISTAS



        List<string> jogadores = new List<string>();
        List<int> pontos = new List<int>();
        List<int> vitorias = new List<int>();
        List<int> derrotas = new List<int>();
        List<int> empates = new List<int>();



        //main
        public static void Main(string[] args)
        {
            Abertura();

            Showmenu();


            int option;

            do
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0 :
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\tPrograma encerrado...");
                        Console.ResetColor();
                        break;
                    case 1 :
                        Cadastrarjogador(jogadores, pontos, vitorias,derrotas,empates);
                        break;

                }

            } while (option != 0);

        }

     
    }
}