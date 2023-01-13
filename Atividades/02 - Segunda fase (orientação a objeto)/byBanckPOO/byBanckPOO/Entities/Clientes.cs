namespace byBanckPOO.Entities
{
    internal class Clientes
    {
        //atributos

        public string Cpf { get; set; }

        public string Senha { get; set; }



        //construtor 
        public Clientes(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;
        }



        



    }
}
