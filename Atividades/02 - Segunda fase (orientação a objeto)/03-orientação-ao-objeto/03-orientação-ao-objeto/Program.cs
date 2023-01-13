using _03_orientação_ao_objeto.Entity;
using System.Drawing;

namespace aula3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circulos c1 = new Circulos(0.3, 0.3, Color.VERDE);

            Console.WriteLine(Color.VERDE.ToString());

            Console.WriteLine(c1.Raio);
            Console.WriteLine(c1.Perimetro);
            Console.WriteLine(c1.Area);
        }
    }
}