using System;
using System.Collections.Generic;
{
    
}

namespace DIO.bank
{
    public class Conta
    {
        private TipoConta TipoConta { get ; set ; }
        private double Saldo {get ; set ; }
        private double Credito { get ; set ; }
        private string Nome { get ; set ; }
    
        // Método Construtor , onde é criado o objeto.

        public Conta(TipoConta tipoConta, double saldo, double credito, String nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }



        public bool Sacar(double valorSaque)  
        // Validação do saldo suficiente
        {
            if (this.Saldo - valorSaque < (this.Credito =-1)) {
                Console.Writeline("Saldo Insuficiente !");
                return false;
        }
            this.Saldo -= valorSaque;
            Console.Writeline(" Saldo atual da conta de {0} é {1} ", this.Nome, this.Saldo);
            return True;
            
        }

            public void Depositar(double ValorDeposito)
             {
                this.Saldo += valorDeposito;
                Console.Writeline("Saldo atual da Conta de {0} é {1}", this.Nome, this.Saldo);
            }

            public void Transferir(double valorTransferencia, Conta contaDestino)
            {
                if (this.Sacar(valorTransferencia)) {
                    contaDestino.Depositar(valorTransferencia);
                }
            }

            public override string ToString()
           
            {
            string retorno = "";
            retorno +=  "TipoConta " + this.TicoConta +" ! ";
            retorno +=  "Nome " + this.Nome +" ! ";
            retorno +=  "Saldo " + this.Saldo +" ! ";
            retorno +=  "Crédito " + this.Credito +" ! ";
            return retorno;
            } 
        }
    }

