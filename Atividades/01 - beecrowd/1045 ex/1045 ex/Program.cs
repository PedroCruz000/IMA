using static System.Net.Mime.MediaTypeNames;

namespace ex1045
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, C,temporaia;
            string linha = Console.ReadLine();
            string[] numeros = linha.Split();

            A = double.Parse(numeros[0]); 
            B = double.Parse(numeros[1]);
            C = double.Parse(numeros[2]);

            if (A < B)
            {
                temporaia = A ;
                A = B;
                B = temporaia;  
            }
            if (A <C)
            {
                temporaia = A ;
                A = C;
                C = temporaia;
            }
            if (B <C)
            {
                temporaia = B ;
                B = C;
                C = temporaia;  
            }
            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                System.Threading.Thread.CurrentThread.Abort();
            }
            
            if ( (A * A) == (B * B) + (C * C )) {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ((A * A) > (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if ((A * A) < (B * B) + (C * C))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (A == B && A == C )
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((A == B && A != C) || (A == C && A != B) || (B == C && B !=A ))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
           
            
        }
    }
}