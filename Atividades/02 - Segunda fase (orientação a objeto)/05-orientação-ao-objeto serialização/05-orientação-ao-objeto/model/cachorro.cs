using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_orientação_ao_objeto.model
{
    public class Cachorro
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }


        public override string ToString()
        {
            return $"Nome: {Nome} Idade: {Idade} Raça {Raca}";
        }

    }
}
