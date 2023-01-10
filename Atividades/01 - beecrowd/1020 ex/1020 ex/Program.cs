namespace ex1020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int idadeAno = idadeEmDias / 365;
            int restoDias = idadeEmDias % 365;

            int idadeMeses = restoDias / 30;
            int restoDias2 = restoDias % 30;

            Console.WriteLine($"{idadeAno} ano(s)");
            Console.WriteLine($"{idadeMeses} mes(es)");   
            Console.WriteLine($"{restoDias2} dia(s)");
            
        }
    }
}