
using System;
using System.Globalization;

namespace Course
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string nome, double depositoInicial)
        {
            Numero = conta;
            Nome = nome;
            Deposito(depositoInicial);
        }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Nome
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
