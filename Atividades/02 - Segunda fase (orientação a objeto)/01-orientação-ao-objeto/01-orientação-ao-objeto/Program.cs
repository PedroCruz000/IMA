using _01_orientação_ao_objeto.Entities;

namespace Orientaçãoaoobjeto
{
  
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno pedro = new Aluno();

            pedro.Nome = "Pedro Cruz";
            pedro.Idade = 28;

            Console.WriteLine($"o nome do aluno é {pedro.Nome}");

            Console.WriteLine($"a idade do aluno é  {pedro.Idade}");

            
            pedro.fazerAniversario();

            Console.WriteLine($"a idade do aluno é  {pedro.Idade}");


            // criando uma lista de alunos.

            List<Aluno> turma = new List<Aluno>();

            turma.Add(pedro); 
            
                
            


        }
    }
}