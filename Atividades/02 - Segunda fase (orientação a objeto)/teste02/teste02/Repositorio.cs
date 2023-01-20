using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste02
{
    internal class Repositorio
    {
     
        private static List<Jogador> _jogador = new List<Jogador>();

        public static void Cadastar(Jogador jogador)
        {
            _jogador.Add(jogador);
        }
    }
}
