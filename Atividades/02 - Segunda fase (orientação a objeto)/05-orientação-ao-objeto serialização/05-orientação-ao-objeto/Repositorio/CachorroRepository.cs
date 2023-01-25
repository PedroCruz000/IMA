
using _05_orientação_ao_objeto.model;
using System.Text.Json;

namespace _05_orientação_ao_objeto.Repositorio;

public class CachorroRepository
{
    

    private readonly string arquivojson = "dogs.json";

    public List<Cachorro> LerTodos()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        //ler todo o arquivo 
        string jsonLines = File.ReadAllText(arquivojson);
        //passar o arquivo para ser deserializado
        List<Cachorro> cachorros = new List<Cachorro>();
        List<Cachorro>? leitura = JsonSerializer.Deserialize<List<Cachorro>>(jsonLines, options);
        if (leitura!= null)
            cachorros.AddRange(leitura);

        return cachorros;
    }
    // criar um metodo 
    // serializa a lista 
    public bool SalvarTodos(List<Cachorro> cachorros)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string cachorrojson = JsonSerializer.Serialize(cachorros, options);
        File.WriteAllText(arquivojson, cachorrojson);
        return true;
    }
   // public List<Cachorro> ListarTodos() { 

   // }
}