using System.Collections.Generic;
using System.Xml;

namespace estudosLista
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> Sequencia = new List<int>();

            // int? nota = null;  ( para deixar numero nulo ) 

           

            Sequencia.Add(2);
            Sequencia.Add(3);
            Sequencia.Add(4);
            Sequencia.RemoveAt(0);

            


            // contar a quantidade de elementos da lista 
            Console.WriteLine("tamanho da lista = " + Sequencia.Count);


            // verificar um elemento na lista
            Console.WriteLine("contem 2?: " + Sequencia.Contains(2));

            Sequencia.Add(2);


            foreach (int i in Sequencia)
            {
                Console.WriteLine(i);
            }

            // remover todos os elementos especificos
            var result4 = Sequencia.RemoveAll(x => x == 2);

            Console.WriteLine("numero de elementos removidos" + result4);  

            



            List<int> Lista2 = new List<int>();

            Lista2.Add(9);

            // adicionar uma lista dentro de uma lista
            Lista2.AddRange(Sequencia);

            // adicionar um item na lista em uma posição especifica, sem substituir.
            Lista2.Insert(2, 999);



            foreach (int i in Lista2)
            {
                Console.WriteLine(i);
            }

        }
    }
}