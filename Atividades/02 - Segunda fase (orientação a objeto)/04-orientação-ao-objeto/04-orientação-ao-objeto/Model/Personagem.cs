namespace _04_orientação_ao_objeto.Model
{
    public class Personagem
    {
        public string Nome { get; set; } = null!; //não vai ser nulo 

        public double Forca { get; protected set; }

        public double Velocidade { get; protected set; }

        public double Defesa { get; protected set; }

        public bool IsAlive { get; protected set; } = true;


    }
}
