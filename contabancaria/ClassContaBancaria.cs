using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace contabancaria
{
    class ClassContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } // Sera alterado apenas pela funcao Depósito e Saque

        //Construtor
        public ClassContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        /*
        // Difilcuta a mantencao
        public ClassContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
        */

        //Facilita a manutencao
        public ClassContaBancaria(int numero, string titular, double depositoinicial) : this(numero, titular)
        {
            Deposito(depositoinicial); //Encapsulamento
        }
        // Método
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }
        public override string ToString()
        {
            return "Conta "
                     + Numero
                     + ", Titular: "
                     + Titular
                     + ", Saldo: $ "
                     + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
