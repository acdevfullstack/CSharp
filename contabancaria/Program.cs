using System;
using System.Globalization;

namespace contabancaria
{
    class Program
    {
        private static void Main(string[] args)
        {
            ClassContaBancaria conta;

            Console.Write("Entre com número da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Hávera depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ClassContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ClassContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            // Depósito
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);

            //Saque
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);




        }
    }
}