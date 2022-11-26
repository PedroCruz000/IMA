namespace ex1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //produto 01 
            int codigoDoProdutoP1 = int.Parse(Console.ReadLine());  
            int numeroDeItensP1 = int.Parse(Console.ReadLine());
            float preçoDaUnidadeP1 = float.Parse(Console.ReadLine());
            
            //produto 02 
            int codigoDoProdutoP2 = int.Parse(Console.ReadLine());
            int numeroDeItensP2 = int.Parse(Console.ReadLine());
            float preçoDaUnidadeP2 = float.Parse(Console.ReadLine())a;

            double valorAPagar = (numeroDeItensP1 * preçoDaUnidadeP1) + (numeroDeItensP2 * preçoDaUnidadeP2);
            Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagar:f2}");
        }
    }
}