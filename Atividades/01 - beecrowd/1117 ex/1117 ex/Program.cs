﻿namespace ex1117
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int notasValidas = 0;
            double nota1 = 0;
            double nota2 = 0;  

            for (int i = 0; notasValidas <= 2; i++)
            {
                double nota = double.Parse(Console.ReadLine());

                if (nota >=0 && nota <= 10 && notasValidas ==0)
                {
                    
                    nota1 = nota;
                    notasValidas = notasValidas + 1;
                }

                else if(nota >= 0 && nota <= 10 && notasValidas == 1)
                {
                    
                    nota2 = nota;
                    notasValidas = notasValidas + 1;
                }

                else
                {
                    Console.WriteLine("nota invalida");
                }

                if (notasValidas == 2)
                {
                    double media = (nota1 + nota2) /2;
                    Console.WriteLine($"media = {media:f2}");
                    break;
                }
                
             
                
            }
        }
    }
}