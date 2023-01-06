using System;
using System.Linq;

namespace bybankPedroCruz
{
    public class Program
    {

        //MENU PRINCIPAL
        static void ShowMenuPrincipal()
        {

            Console.WriteLine("1 - Criar uma conta");
            Console.WriteLine("2 - Acessar uma conta");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        //CRIAR UMA CONTA

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("");
            Console.WriteLine("Para Criar uma conta siga os passos abaixo:");
            Console.WriteLine("");


            Console.Write("Digite seu CPF: ");
            cpfs.Add(Console.ReadLine());

            Console.Write("Digite Seu Nome: ");
            titulares.Add(Console.ReadLine());

            Console.Write("Digite Sua senha: ");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);


            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Usuario adicionado com sucesso!");
        }



        // ACESSAR UMA CONTA 


        static void AcessarUmaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Bem vindo ao Espaço do cliente!");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------");


            Console.Write("Digite seu CPF: ");
            string cpfParaLogin = Console.ReadLine();
            int indexParaLogin = cpfs.FindIndex(cpf => cpf == cpfParaLogin);

            if (indexParaLogin == -1)
            {
                Console.WriteLine("Não foi possivel fazer logim");
                Console.WriteLine("Motivo: conta não encontrada.");
            }
            else
            {
                Console.Write("Digite sua Senha: ");
                string senhaParaValidar = Console.ReadLine();
                int indexParaSenha = senhas.FindIndex(senha => senha == senhaParaValidar);
                
                if (indexParaSenha == -1)
                {
                    Console.WriteLine("Senha incorreta");
                }

                else
                {
                    Console.WriteLine("acesso liberado");
                    EspacoDoCliente(indexParaLogin, cpfs, titulares, saldos);
                    
                }
            }


        }

        // espaço do cliente
        static void EspacoDoCliente(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            // boas vindas do espaço do cliente 

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Olá {titulares[index]}, bem vindo ao Espaço do cliente:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            //mostrar as informações da conta 
            Console.WriteLine($"CPF = {cpfs[index]} | Titular = {titulares[index]} | Saldo = R${saldos[index]:F2}");
            Console.WriteLine("");

            // mostrar menu do cliente 
            MenuDoCliente(index, cpfs, titulares, saldos);

        }

        //menu do cliente
        static void MenuDoCliente( int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            int optionMenuCliente;

            do
            {
                Console.WriteLine("1 - Deposito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Transferência");
                Console.WriteLine("4 - Saldo");
                Console.WriteLine("0 - Para sair do espaço do Cliente");
                Console.Write("Digite a opção desejada: ");
                optionMenuCliente = int.Parse(Console.ReadLine());

                switch (optionMenuCliente)
                {
                    case 0: 
                        Console.WriteLine("Voltando ao menu anterior...");
                        break;
                    case 1: Deposito(index,cpfs, titulares, saldos);
                        break;
                    case 2: Saque(index,cpfs,titulares, saldos);
                        break;
                    case 3: Transferencia(index,cpfs,titulares,saldos);
                        break;
                    case 4: Saldo(index, cpfs, titulares, saldos);
                        break;
                    

                }
               

            } while (optionMenuCliente != 0);

            
        }

      







        //Deposito
        private static void Deposito( int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($" Voce selecionou a opção deposito:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine($"Seu saldo atual é: Saldo = R${saldos[index]:F2}");

            Console.Write("Digite o valor a ser depositado:");
            double valorDepositado = double.Parse(Console.ReadLine());
            saldos[index] += valorDepositado;

            Console.WriteLine("");
            Console.WriteLine($"saldo atualizado de {saldos[index]:F2}");
            Console.WriteLine("");

        }

        //Saque

        static void Saque(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($" Voce selecionou a opção Saque:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine($"Seu saldo atual é: Saldo = R${saldos[index]:F2}");

            Console.Write("Digite o valor a ser sacado: ");
            double valorSacado = double.Parse(Console.ReadLine());
            saldos[index] -= valorSacado;

            Console.WriteLine("");
            Console.WriteLine($"saldo atualizado de {saldos[index]:F2}");
            Console.WriteLine("");
        }


        //Transferencia


        static void Transferencia(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($" Voce selecionou a opção Transferência:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Seu saldo atual é: Saldo = R${saldos[index]:F2}");
            Console.WriteLine("");

            Console.Write("digite o CPF da conta que você deseja fazer a transferência: ");

            string cpfParaTransferir = Console.ReadLine();
            int indexSegundoTitular = cpfs.FindIndex(cpf => cpf == cpfParaTransferir);

            if (indexSegundoTitular == -1)
            {
                Console.WriteLine("Não foi possivel localizar esta conta");
                Console.WriteLine("Motivo: conta não encontrada.");
            }
            else
            {
                //Console.WriteLine($"cpf = {cpfs[indexSegundoTitular]} Titula= {indexSegundoTitular[indexParaLogin]}");

                Console.Write("Digite o valor que deseja transferir: ");
                double valorDaTransferencia = double.Parse(Console.ReadLine());

                saldos[index] -= valorDaTransferencia;
                saldos[indexSegundoTitular] += valorDaTransferencia;

                Console.WriteLine("");
                Console.WriteLine($"saldo atualizado de {saldos[index]:F2}");
                Console.WriteLine("");
            }

        }

        //SALDO

        static void Saldo(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($" Voce selecionou a opção Saldo:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("");
            Console.WriteLine($"Seu saldo atual é: Saldo = R${saldos[index]:F2}");
            Console.WriteLine("");


        }















        public static void Main(string[] args)
        {

            //apresentação de boas vindas 

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Seja Bem Vindo ao banco Imã o melhor e o mais seguro do Brasil.");


            //listas 

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();  
            List<double> saldos= new List<double>();

            int option;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("");

                ShowMenuPrincipal();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: 
                        Console.WriteLine("Programa encerrado...");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        AcessarUmaConta(cpfs,titulares, senhas, saldos);
                        break;
                }


            } while (option != 0);

        }

        
    }
}