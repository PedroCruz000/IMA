
namespace _01_orientação_ao_objeto.Entities
{
    public class Aluno
    {
        // atributos 
        public string Nome;
        public int Idade;
        public double? Nota;
        public bool? Aprovado;

        //métodos
        public void fazerAniversario()
        {
            Idade++;
        }

        public void fazerPova(double notaDaProva)
        {
            Nota = notaDaProva;
        }

        public bool? EstaAprovado()
        {
            if (Nota == null)
                return null;

            if (Nota >= 7.0)
                return true;

            return false;

        }
    }
}
