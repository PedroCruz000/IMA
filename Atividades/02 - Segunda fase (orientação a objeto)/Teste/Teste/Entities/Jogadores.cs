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
            Console.Clear();
            Console.WriteLine("\n\tJogador cadastrado com sucesso!");           
            Console.WriteLine($"\n\tO nome do titular cadastrado é {novoJogador.Nome}");
            Console.WriteLine("\n\tDigite uma tecla para continuar");
            Console.ReadKey();
            Console.ResetColor();

         

        }






    





    }
}
