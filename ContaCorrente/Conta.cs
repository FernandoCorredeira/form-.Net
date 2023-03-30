using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public string VerSaldo()
        {
            return $"o saldo do correntista: {Titular}, conta número {Numero} é de: {Saldo.ToString()}";
        }

        public void Depositar(double Saldo)
        {
            this.Saldo += Saldo;
        }
        public void Sacar(double Saldo)
        {
            this.Saldo -= Saldo;
        }

        public void Transferir(double Saldo, Conta destino)
        {
            
            if (Saldo <= 0) {
                Saldo += 100;           
            }
            this.Saldo -= Saldo;
            destino.Saldo += Saldo;

            
        }
    }
}
