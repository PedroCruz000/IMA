using _05_orientação_ao_objeto.model;
using _05_orientação_ao_objeto.Repositorio;
using System.Text.Json;

namespace orientaçãoaoobjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //      cachorros é uma variavel
            List<Cachorro> cachorros = new List<Cachorro>
            {

               
                new Cachorro {Nome = "Thor",Idade = 5,Raca = "Pastor Suiço" },
                new Cachorro {Nome = "billy",Idade = 6,Raca = "pintcher" },
                new Cachorro {Nome = "tequila",Idade = 5,Raca = "Gato desfarçado" },
                new Cachorro {Nome = "mel",Idade = 2,Raca = "Pastor Alemão" },
                new Cachorro {Nome = "plim plim",Idade = 2,Raca = "Pastor Alemão" },


            };

            CachorroRepository repository = new CachorroRepository();

            repository.SalvarTodos(cachorros);
            repository.LerTodos().ForEach(Console.WriteLine);

            //Console.WriteLine(repository.SalvarTodos(cachorros) ? "Salvou!" : "Erro ao Salvar!");
            //Console.WriteLine(repository.PegarDoArquivo());
            

            
            
            


        }
    }
}