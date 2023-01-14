using _02_orientação_ao_objeto.model;

namespace _02_orientação_ao_objeto
{
public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa pedro = new Pessoa("Pedro Cruz", 1.80, 28,"99299-8803");

            Console.WriteLine(pedro.Nome);
        }
    }
}