namespace projetoBanco
{
    public class Program
    {
        // MENU
        static void MostrarOMenu()
        {
            Console.WriteLine("1 - Inserir novo Usuário");
            Console.WriteLine("2 - Deletar um Usuário");
            Console.WriteLine("3 - Detalhes do Usuário");
            Console.WriteLine("4 - Saldo");
            Console.WriteLine("0 - sair");
            Console.Write("Digite a opção desejada:");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(" Antes de começão a usar, vamos configurar alguns valores:");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<double> saldos = new List<double>();
           

            
            
            int option;

            do
            {
                MostrarOMenu();
                option = int.Parse(Console.ReadLine());

                //REALIZAR OPÇÃO DESEJADA

                if (option == 0)
                {
                    Console.WriteLine("Encerrando o Programa...");
                }


                else if (option == 1)
                {
                    //realizar opão 1 

                    RegistrarNovoUsuario(cpfs, titulares, saldos);
                    
                }


                else if (option == 2)
                {
                    //realizar opão 2
                }


                else if (option == 3)
                {

                }


                else if (option == 4)
                {
                    
                }



            } while (option != 0);

     
                       
        } 
    }
}