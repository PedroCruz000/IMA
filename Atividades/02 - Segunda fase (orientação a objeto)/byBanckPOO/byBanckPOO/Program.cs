using byBanckPOO.Entities;
using byBanckPOO.Model;

namespace byBanckPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Conta contaPedro = new Conta(003,"01413747213","senha1234");
            Conta contaValesca = new Conta(004,"01413747219","senha1234");


            contaPedro.Depositar(200.0);
            contaPedro.Depositar(200.0);

            Console.WriteLine($"saldo é igual= {contaPedro.Saldo}");

            contaPedro.Sacar(375.0);


            Console.WriteLine($"saldo é igual= {contaPedro.Saldo}");

            contaPedro.Sacar(0);

            Console.WriteLine($"saldo da conta pedro é igual= {contaPedro.Saldo}"); 
            Console.WriteLine($"saldo da conta valesca é igual= {contaValesca.Saldo}");

            contaPedro.Depositar(100);

            Console.WriteLine($"saldo da conta pedro é igual= {contaPedro.Saldo}");
            Console.WriteLine($"saldo da conta valesca é igual= {contaValesca.Saldo}");

            
            contaPedro.Trasferir(25, contaValesca);

            Console.WriteLine($"saldo da conta pedro é igual= {contaPedro.Saldo}");
            Console.WriteLine($"saldo da conta valesca é igual= {contaValesca.Saldo}");

        }
    }
}