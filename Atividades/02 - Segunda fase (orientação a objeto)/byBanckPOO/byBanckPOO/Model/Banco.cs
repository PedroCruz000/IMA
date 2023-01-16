using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byBanckPOO.Model
{
    public class Banco
    {
        //atributo 

        private Conta? _contaLogada;
        private List<Conta> _contas;

        public readonly string Agencia;

        public Banco (string Agencia)
        {
            _contas = new List<Conta>();
            _contaLogada = null;
            Agencia = Agencia;

        }

        //métodos 
         public void register()
        {
            // TO DO apresentar um menu de registro
            string cpf = Console.ReadLine();
            string senha = Console.ReadLine();
            long id = _contas.Count + 1;
            _contas.Add(new Conta(id, cpf, senha));
        }

        public void login()
        {
            

        }

        public void logout() 
        { 

        }

      
    }
}
