using Teste.Entities;
using Teste.inicio;

namespace Teste
{
    public class Program
    {
        public static string nome { get; private set; }

        public static void Main(string[] args)
        {
            Menu.Abertura();

            Console.Clear();

            int option;
            do
            {
                Menu.ShowMenu();
                Console.Write("\n\t Digite uma opção:");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\n\n\n\n\t Encerrando programa...\n\n\n\n\n");
                        Console.ResetColor();
                        break;

                    case 1:
                        Jogadores.Cadastrar();
                      

                        break;
                        

                }
            }
            while (option != 0);
            
            
            

           /* Jogadores jogadores = new Jogadores(nome);

            jogadores.CadastrarJogadores();

            Console.WriteLine($"o nome do jogador informado é {jogadores.Nome}");*/

        }
    }
}