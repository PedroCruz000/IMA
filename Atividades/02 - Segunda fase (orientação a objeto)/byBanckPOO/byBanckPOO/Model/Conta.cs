using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byBanckPOO.Model
{
    internal class Conta
    {
        public Conta()
        {
        }


        //atributo
        public long Id { get; private set; }
        public string Cpf { get; private set; } = null!;
        public string Senha { get; private set; } = null;
        public double Saldo { get; private set; }
        public bool EstaBloqueada { get; private set; }

        //contrutor
        public Conta(long id, string cpf, string senha)
        {
            Id = id;
            Cpf = cpf;
            Senha = senha;
            Saldo = 0.0;
            EstaBloqueada = false;
        }

        //metodo
        public bool Depositar (double quantia)
        {
            if (EstaBloqueada)
                return false;

            Saldo += quantia;
            return true;
        }

      
        public bool Sacar ( double quantia)
        {
            if (EstaBloqueada)                          
                return false;
                                        

            if (Saldo < quantia)              
                return false;


            Saldo -= quantia;
            return true;
        }

        public bool Trasferir (double quantia, Conta contaDestino)
        {
            //utilizando o this prara especificar quem esta chamando a ação, neste caso quem está chamando a função transferir 
            //ex contaPedro.transferir 
            // o this expecifica a contaPedro 


            //validação 1
            if (contaDestino.EstaBloqueada)
                return false;


            //validação 2
            if (!this.Sacar(quantia))           
                return false;

            
            return contaDestino.Depositar(quantia);
        }









    }
}
