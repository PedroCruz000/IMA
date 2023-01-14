namespace _02_orientação_ao_objeto.model
{
    public class Funcionario
    {
        //atributos

        private double _salarioBruto;
        private double _imposto;


        //proprietis

      

        public double SalarioLiquido
        {
            get { return _salarioBruto - Imposto; }
            set { return; }
        }

        //auto proprieties prop + tab + tab

        public double SalarioBruto { get; private set; }
        public double Imposto { get; set; }

    }
}
