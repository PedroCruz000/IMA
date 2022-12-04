using System.Xml;

namespace ex1040
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            string[] numeros = linha1.Split();

            double n1 = double.Parse(numeros[0]);
            double n2 = double.Parse(numeros[1]);
            double n3 = double.Parse(numeros[2]);
            double n4 = double.Parse(numeros[3]);
     
            double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

            Console.WriteLine($"Media: {media:f1}");


            //media superior a 7

            if (media >= 7 )
            {
                Console.WriteLine($"Aluno aprovado.");
            }

            // media menor que 5 

            else if (media < 5 )
            {
                Console.WriteLine($"Aluno reprovado.");
            }

            // media entre 5 e 6,9

            else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine($"Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame}");
                double mediaRecupera = (media + notaExame) / 2;

                if (mediaRecupera >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {mediaRecupera}");
                }
                else if (media <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            }
               
        }
    }
}