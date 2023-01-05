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
            Console.WriteLine("6 - Manipular a conta");
            Console.WriteLine("0 - sair");
            Console.Write("Digite a opção desejada:");
        }

        // REGISTRAR UM USUARIO
        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares,List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o Cpf:");
            cpfs.Add(Console.ReadLine());

            Console.Write("Digite o nome:");
            titulares.Add(Console.ReadLine());

            Console.Write("Digite a Senha:");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);
        }

        // DELETAR UM USUÁRIO 

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf:");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex( d=> d == cpfParaDeletar);
           

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possivel deletar esta conta");
                Console.WriteLine("Motivo: conta não encontrada.");
            }
            
            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletada com sucesso");


        }
        static void listarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Write("Digite o cpf:");
            string cpfParaApresentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(cpf => cpf == cpfParaApresentar);


            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Não foi possivel apresentar esta conta");
                Console.WriteLine("Motivo: conta não encontrada.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        static double soma(List<double> saldos)
        {
            return saldos.Aggregate(0.0,(x,y) => x + y);
        }
        //não sei o que é isso 
      


        static void ApresentaConta(int index , List<string> cpfs, List<string> titulares, List<double> saldos, int i)
        {
            Console.WriteLine($"CPF = {cpfs[index]} | Titular {titulares[index]} | Saldos R$ {saldos[index]:F2}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(" Antes de começão a usar, vamos configurar alguns valores:");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
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
                        RegistrarNovoUsuario(cpfs, titulares,senhas,saldos);
                        break;
                    case 2:
                        DeletarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 3:
                        listarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        apresentarUsuario(cpfs, titulares, saldos);
                        break;

                }
         



            } while (option != 0);



        }

     
    }
}