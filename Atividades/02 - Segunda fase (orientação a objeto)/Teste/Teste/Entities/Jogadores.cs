using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Teste.Entities
{
    public class Jogadores
    {
        //atributo
        public string Nome { get; set; } = null;

        //construtor 

        public Jogadores(string nome)
        {
            Nome = nome;

        }


        //metodo

        public static List<Jogadores> listaJogadores = new List<Jogadores>();
        public static string PegarNome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\tDigite seu Nome: ");
            Console.ResetColor();
            string name = Console.ReadLine();

            return name;

        }
        public static void Cadastrar()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tcadastrar um novo jogador:");            
            string nomeDoUsuario = PegarNome();
            Jogadores novoJogador = new Jogadores(nomeDoUsuario);
            listaJogadores.Add(novoJogador);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tjogador cadastrado com sucesso!");
            Console.WriteLine("\n\tdigite uma tecla para continuar");
            

            foreach (Jogadores item in listaJogadores)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.ResetColor();

        }






    





    }
}
