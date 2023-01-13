
using System.Drawing;

namespace _03_orientação_ao_objeto.Entity
{
    internal class Circulos
    {

        //atributos 

        public static readonly double PI = 3.14159265;
        public double Espessura { get; set; }
        public double Raio { get; set; }
        public Color Cor { get; set; }

        // construtores 
        public Circulos(double raio)
        {
            Raio = raio;
        }
        public Circulos(double espessura,double raio,Color cor)

            : this(raio)
        {
            Espessura= espessura;
            Cor = cor;
        }


        // propritedades

        public double Perimetro
        {
            get { return 2 * PI * Raio; }
        }

        public double Area
        {
            get { return 2 * PI * Raio * Raio; }
        }

    }
}
