using System;

namespace Bank
{
    public class Conta
    {
        private string Nome {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private TipoConta TipoConta {get; set;}

        public Conta(string Nome, double Saldo, double Credito, TipoConta tipoConta)
        {
            this.Nome = Nome;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque){
            if (this.Saldo - valorSaque  < this.Credito*-1){
                return false;
            }

            this.Saldo -= valorSaque;
            return true;
        }

        public void Depositar(double valorDeposito){
            this.Saldo += valorDeposito;
        }

        public bool Transferir(double valorTransferencia, Conta contaDestino){
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
                return true;
            }else{
                return false;
            }
        }

        public override string ToString()
        {
            string r = "";
            r += "Nome: " + this.Nome + " | ";
            r += "Saldo: " + this.Saldo + " | ";
            r += "Credito: " + this.Credito + " | ";
            r += "TipoConta: " + this.TipoConta ;

            return r;            
        }
    }
}