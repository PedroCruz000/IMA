
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using teste02.Entities;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace teste02.Repositorio
{
    public class Json
    {
        
        
        private static string path = "Dados.json";

        public static List<Jogador> jogadores = Desserializar();
        public Json()
        {
            if (!File.Exists(path)) File.Create(path).Close();
        }




        public static void Adicionar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\tCadastrar novo Jogador. ");
            Console.ResetColor();
            string nome = Menu.PegarNome();
            nome = Menu.ExisteJogador(nome);
            Jogador jogador = new Jogador(nome);
            jogadores.Add(jogador);
            Serializar();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\t Jogador cadastrado com sucesso.");
            Console.WriteLine("\n\t Precione uma tecla para voltar ao menu");
            Console.ReadKey();

            Console.ResetColor();
            
        }
        internal static void Remover()
        {
            throw new NotImplementedException();
        }


        public static void Serializar()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, jogadores);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t{e.Message}");
                Console.ResetColor();
            }
        }

        public static List<Jogador> Desserializar()
        {
            List<Jogador> jogadores = new List<Jogador>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string jsonString = sr.ReadToEnd();
                    jogadores = JsonConvert.DeserializeObject<List<Jogador>>(jsonString);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t{e.Message}");
                Console.ResetColor();
            }
            return jogadores;
        }

 
    }
}
