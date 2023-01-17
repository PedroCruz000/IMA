using _04_orientação_ao_objeto.Model;

namespace orientaçãoAoObijeto04Heranca
{
     public class Progra
    {
        public static void Main(string[] args)
        {
            Arqueiro arq = new Arqueiro();
            arq.NovoArco(new Arco(TipoDoArco.VENENOSO));

            Console.WriteLine(arq.Arco.Forca);
            Console.WriteLine(arq.Nome);

        }
    }
}