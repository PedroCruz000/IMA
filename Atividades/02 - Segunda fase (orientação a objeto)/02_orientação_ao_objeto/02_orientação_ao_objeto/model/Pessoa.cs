namespace _02_orientação_ao_objeto.model
{
    public class Pessoa
    {
        // atributos  // Propreties (é uma maneira de escrever os get em set mais abreviados.

        private string Nome { get; set; }
        private double Altura { get; set; }
        private int Idade { get; set; }
        private string Telefone { get; set; }


        //contrutor 
        public Pessoa(string nome, double altura, int idade, string telefone)
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
            Telefone = telefone;
        }

      


        // metodo
        
       public void FazerAniversario()
        {
            Idade++;
        }



    }
}
