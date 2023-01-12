using byBanckPOO.Entities;

namespace byBanckPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("cadastre um cliente");
            Clientes cliente = new Clientes();

            Console.WriteLine("Digite o CPF:");
            cliente.Cpf= Console.ReadLine();

            Console.WriteLine($"o cpf digitado foi {cliente.Cpf}");

        }
    }
}