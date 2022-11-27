namespace ex1012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split(' ');

            double a = double.Parse(numeros[0]);
            double b = double.Parse(numeros[1]);
            double c = double.Parse(numeros[2]);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = 3.14159 * c * c;
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo:f3}\nCIRCULO: {areaCirculo:f3}\nTRAPÉZIO: {areaTrapezio:f3}\nQUADRADO: {areaQuadrado:f3}\nRETANGULO: {areaRetangulo:f3}");
            //Console.WriteLine($"CIRCULO: {areaCirculo:f3}");
            //Console.WriteLine($"TRAPÉZIO: {areaTrapezio:f3}");
            //Console.WriteLine($"QUADRADO: {areaQuadrado:f3}");
            //Console.WriteLine($"RETANGULO: {areaRetangulo:f3}");

        }
    }
}