using teste02;

namespace Teste02
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("olá seja bem vindo:");
            Console.WriteLine("vamos te cadastrar");
            string nome = Console.ReadLine();
            Jogador novoJogador = new Jogador(nome);
            Repositorio.Cadastar(novoJogador);
            Console.WriteLine("usuario cadastrado com sucesso!");

            foreach (string item in Jogador)
            {
                Console.WriteLine(item);
            }



        }
    }
}