namespace _04_orientação_ao_objeto.Model
{
    public class Arco
    {
        private double _forca;
        public TipoDoArco TipoDoArco { get; set; }

        public double Forca
        {
            get{
                switch (TipoDoArco)
                {
                    case TipoDoArco.EXPLOSIVO:
                        _forca = 200.0;
                        break;
                    case TipoDoArco.VENENOSO:
                        _forca = 30.0;
                        break;
                    default:
                        _forca = 80.0;
                        break;  
                }
                return _forca;
                
            }
        }
        
        public Arco(TipoDoArco tipoDoArco)
        {
          TipoDoArco= tipoDoArco;
        }
        
    }
}