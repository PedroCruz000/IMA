namespace ex1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double reajusteGanho,novoSalario;

            if (salario >= 0 && salario <= 400)
            {
                reajusteGanho = salario * 0.15;
                novoSalario = salario + reajusteGanho;
                Console.WriteLine($"Novo salario: {novoSalario:f2}");
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:f2}");
                Console.WriteLine($"Em percentual: 15 %");
            }
            else if (salario > 400 && salario <= 800)
            {
                reajusteGanho = salario * 0.12;
                novoSalario = salario + reajusteGanho;
                Console.WriteLine($"Novo salario: {novoSalario:f2}");
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:f2}");
                Console.WriteLine($"Em percentual: 12 %");
            }
            else if (salario > 800 && salario <= 1200)
            {
                reajusteGanho = salario * 0.10;
                novoSalario = salario + reajusteGanho;
                Console.WriteLine($"Novo salario: {novoSalario:f2}");
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:f2}");
                Console.WriteLine($"Em percentual: 10 %");
            }
            else if (salario > 1200 && salario <= 2000)
            {
                reajusteGanho = salario * 0.07;
                novoSalario = salario + reajusteGanho;
                Console.WriteLine($"Novo salario: {novoSalario:f2}");
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:f2}");
                Console.WriteLine($"Em percentual: 7 %");
            }
            else if( salario > 2000)
            {
                reajusteGanho = salario * 0.04;
                novoSalario = salario + reajusteGanho;
                Console.WriteLine($"Novo salario: {novoSalario:f2}");
                Console.WriteLine($"Reajuste ganho: {reajusteGanho:f2}");
                Console.WriteLine($"Em percentual: 4 %");
            }
        }
    }
}