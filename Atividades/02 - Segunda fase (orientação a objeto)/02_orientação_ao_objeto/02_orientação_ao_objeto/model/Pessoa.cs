namespace _02_orientação_ao_objeto.model
{
    public class Pessoa
    {
        // atributos 
        private string _nome { get; set; }
        private double _altura { get; set; }
        private int _idade { get; set; }
        private string _telefone { get; set; }


        //contrutor 
        public Pessoa(string nome, double altura, int idade, string telefone)
        {
            _nome = nome;
            _altura = altura;
            _idade = idade;
            _telefone = telefone;
        }

       

        // metodo

        public int PegarIdade()
        {
            return _idade;
        }


        public void SetIdade(int idadeEntrada)
        {
            if (idadeEntrada <= 0) return;
            _idade= idadeEntrada;
        }


        public void FazerAniversario()
        {
            _idade++;
        }



    }
}
