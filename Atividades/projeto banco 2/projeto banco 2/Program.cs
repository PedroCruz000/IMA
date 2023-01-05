namespace projetoBanco2
{
    public class Program
    {
        // MENU
        static void MostrarOMenu()
        {
            Console.WriteLine("1 - Inserir novo Usuário");
            Console.WriteLine("2 - Deletar um Usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes do Usuário");
            Console.WriteLine("5 - Saldo");
            Console.WriteLine("0 - sair");
            Console.Write("Digite a opção desejada:");
        }
        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Write("Digite o Cpf:");
            cpfs.Add(Console.ReadLine());

            Console.Write("Digite o nome:");
            titulares.Add(Console.ReadLine());
           
            saldos.Add(0);
        }
        static void listarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular {titulares[i]} | Saldos R$ {saldos[i]:F2}");
            }
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

                Console.WriteLine("------------------------");
                //REALIZAR OPÇÃO DESEJADA

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Encerrando o Programa...");
                        break;
                    case 1: 
                        RegistrarNovoUsuario(cpfs, titulares,saldos);
                        break;
                    case 3:
                        listarTodasAsContas(cpfs, titulares, saldos);
                        break;

                }
         



            } while (option != 0);



        }

     
    }
}