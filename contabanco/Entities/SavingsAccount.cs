using System;
using System.Collections.Generic;

namespace contabanco.Entities
{
    class SavingsAccount : Account

    //Classe selada. Evita que a classe seja herdada
    // Palavra chave sealed
    //sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Ao sobrescrever um métado, devemos
        //incluir nele o prefixo "override"
        public override void Withdraw(double amount)

        //Métados selados. 
        //Evita que um métado, sobreposto possa ser sobreposto novamente.
        // Palavra chave sealed
      //  public sealed override void Withdraw(double amount)
        {
            // Balance -= amount; //Saque sem taxa

            //É possivel chamar a implementação da 
            //superclasse usando a palavra base.

            //Exemplo com taxa de 2.0
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
