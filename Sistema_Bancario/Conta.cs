using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sistema_Bancario
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public Conta(int numero, string titular, double depositoInicial)
        {
            CalcularDeposito(depositoInicial);
        }

        public void CalcularDeposito(double quantia)
        {
            Saldo += quantia;
        }

        public void CalcularSaque(double quantia)
        {
            Saldo = Saldo - quantia - 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}\nTitular: {Titular}\nSaldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
