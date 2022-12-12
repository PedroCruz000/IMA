namespace ex1101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0; 
            

          while (true)
            {
                string linha = Console.ReadLine();
                string[] N1N2 = linha.Split();
                
                int n1 = int.Parse(N1N2[0]);
                int n2 = int.Parse(N1N2[1]);              

                if ( n1 <=0 || n2 <= 0 )
                {
                    break;
                }  
                else if ( n1 > n2)
                {
                    
                    for (int i = n2; i <= n1; i++)
                    {
                        Console.Write($"{i} "); 
                        soma = soma+ i;
                    }
                    Console.WriteLine($"Sum={soma}");
                    soma = 0;
                }
                else if (n1 < n2)
                {
                    
                    for (int i = n1; i <= n2; i++)
                    {
                        Console.Write($"{i} ");
                        soma = soma + i;
                    }
                    Console.WriteLine($"Sum={soma}");
                    soma = 0;
                }
              
            }
        }
    }
}