namespace ex1042
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            string[] numeros = linha.Split();

            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);
            int C = int.Parse(numeros[2]);

            int menor1, menor2 = 0, menor3 = 0;
            menor1 = Math.Min(A ,Math.Min(B, C));

            if (menor1 == A)
            {
                menor2 = Math.Min(B, C);
                menor3 = Math.Max(B, C);

                Console.WriteLine(menor1);
                Console.WriteLine(menor2);
                Console.WriteLine(menor3);
                Console.WriteLine("");
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
            }
            if (menor1 == B)
            {
                menor2 = Math.Min(A, C);
                menor3 = Math.Max(A, C);

                Console.WriteLine(menor1);
                Console.WriteLine(menor2);
                Console.WriteLine(menor3);
                Console.WriteLine("");
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
            }
            if (menor1 == C)
            {
                menor2 = Math.Min(A, B);
                menor3 = Math.Max(A, B);

                Console.WriteLine(menor1);
                Console.WriteLine(menor2);
                Console.WriteLine(menor3);
                Console.WriteLine("");
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
            }

        }
    }
}