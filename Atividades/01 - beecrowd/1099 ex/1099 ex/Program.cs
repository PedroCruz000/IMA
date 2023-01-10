namespace ex1099
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int impares = 0;

            for ( int i = 0; i <n ; i++ )
            {
                string linha = Console.ReadLine();
                string[] numerosXY = linha.Split();

                int X = int.Parse(numerosXY[0]);
                int Y = int.Parse(numerosXY[1]);

               if (X < Y)
                {
                    for (int cont = X+1; cont < Y; cont++)
                    {
                        
                        if (cont %2 != 0 )
                        {
                                                       
                            impares = cont + impares;
                        }
                        

                    }
                    Console.WriteLine($"{impares}");
                    impares = 0;    
                  
                    
                }
               else if (X > Y)
                {
                    for (int cont = X-1; cont > Y; cont--)
                    {
                        
                        if (cont %2 != 0)
                        {
                            
                            impares = cont + impares;
                        }
                    }
                    Console.WriteLine($"{impares}");
                    impares= 0; 
                   
                }
               else
                {
                    Console.WriteLine(impares);
                }
             
                
            }  
        }
    }
}