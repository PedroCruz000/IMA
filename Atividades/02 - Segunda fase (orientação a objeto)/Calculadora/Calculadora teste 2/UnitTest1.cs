using System.Security.Claims;
using ProjetoCalculadora;
using static ProjetoCalculadora.Calculadora_teste_2;

namespace Calculadora_teste_2
{


    public static class  CalculadoraTese
    {

        [Fact]// annotations
        public void GiveSomaWhenSomanDoisNumerosThenReturnSum()
        {
            // given arrange 

            double fistValue = 2.0;
            double secondValue = 3.5;
            double expectedValue = 5.0;

            //ação
            // when - act - agir

            double resulValue = Somar(fistValue, secondValue);

            //teste
            //then - asser - teste

            Assert.Equal(expectedValue, resulValue);


            // GTW = Given When Then 


        }

    }
    [Fact]// annotations
    public void GiveProdutoWhenSomanDoisNumerosThenReturnSum()
    {
        // given arrange 

        double fistValue = 2.0;
        double secondValue = 3.5;
        double expectedValue = 5.0;

        //ação
        // when - act - agir

        double resulValue = Multiplicar(fistValue, secondValue);

        //teste
        //then - asser - teste

        Assert.Equal(expectedValue, resulValue);
    }

    public void GiveSubtrairWhenSubtraindoDoisNumerosThenReturnSum()
    {
        // given arrange 

        double fistValue = 10.0;
        double secondValue = 3.0;
        double expectedValue = 7.0;

        //ação
        // when - act - agir

        double resulValue = Subrtrair(fistValue, secondValue);

        //teste
        //then - asser - teste

        Assert.Equal(expectedValue, resulValue);
    }

    public void GiveDividirWhenDividindoDoisNumerosThenReturnSum()
    {
        // given arrange 

        double fistValue = 10.0;
        double secondValue = 3.0;
        double expectedValue = 7.0;

        //ação
        // when - act - agir

        double resulValue = Dividir(fistValue, secondValue);

        //teste
        //then - asser - teste

        Assert.Equal(expectedValue, resulValue);
    }
    public void GiveDividirWhenDividindoDoisNumerosThenReturnSum()
    {
        // given arrange 

        double fistValue = 10.0;
        double secondValue = 3.0;
        double expectedValue = 7.0;

        //ação
        // when - act - agir

        double resulValue = Dividir(fistValue, secondValue);

        //teste
        //then - asser - teste

        Assert.Equal(expectedValue, resulValue);
    }

}