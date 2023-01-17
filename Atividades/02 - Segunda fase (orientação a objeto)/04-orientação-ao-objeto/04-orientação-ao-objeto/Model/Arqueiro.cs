namespace _04_orientação_ao_objeto.Model
{
    public class Arqueiro : Personagem
    {

        public Arco Arco { get; set; }


        public Arqueiro()
        {
            Nome = "Arqueiro";
            Arco = new Arco(TipoDoArco.VENENOSO);
        }
        public void NovoArco()
        {

        }
    }
}
