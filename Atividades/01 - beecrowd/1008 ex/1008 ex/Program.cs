namespace ex1008
{
    public class Program
    {
        public static void Main(string[] args) { 
        
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            int numeroHorasTrabalhadasMes = int.Parse(Console.ReadLine());  
            float valorRecebidoPorHora = float.Parse(Console.ReadLine());

            float salarioMes = numeroHorasTrabalhadasMes * valorRecebidoPorHora;

            Console.WriteLine($"NUMBER = {numeroDoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioMes:f2}");
        }
    }
}