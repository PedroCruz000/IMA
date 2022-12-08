namespace ex1051
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double imposto,saldo,imposto8,imposto18,imposto28;


            if (salario > 0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto:f2}");
            }
            else if (salario > 3000 && salario <= 4500)
            {
                saldo = (salario - 2000);

                if (saldo > 1000)
                {
                    imposto18 = ((saldo - 1000) * 0.18);
                    imposto8 = 1000 * 0.08;
                    double total = imposto18 + imposto8;
                    Console.WriteLine($"R$ {total:f2}");
                   
                }
                else
                {
                    imposto8 = saldo * 0.08;
                    Console.WriteLine($"{imposto8:f2}");

                }
                
            }
            else if (salario > 4500)
            {
                imposto8 = 1000 * 0.08;
                imposto18 = 1500 * 0.18;               
                imposto28 = (salario - 2000 - 1000 - 1500)* 0.28;
                double total = imposto8 + imposto18 + imposto28;
              
                Console.WriteLine($"R$ {total:f2}");

            }

        }
    }
}