namespace ex1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            while(true)
            {
                int senha = int.Parse(Console.ReadLine());

                if (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            }
        }
    }
}