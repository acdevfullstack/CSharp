using System;
using contabanco.Entities;

namespace contabanco;
class Program
{
    private static void Main(string[] args)
    {

        /* Polimorfismo

Na programação orientada a objetos, 
o polimorfismo permite que referências de tipos de classes 
mais abstratas representem o comportamento das classes 
concretas que referenciam. 
Assim, é possível tratar vários 
tipos de maneira homogênea. 
O termo polimorfismo é originário 
do grego e significa "muitas formas".
                */

        Account acc1 = new Account(1001, "Anna", 500.0);
        Account acc2 = new SavingsAccount(1002, "Renata", 500.0, 0.01);

        //Saque
        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);
        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);


        /*
         BusinessAccount account = new BusinessAccount(9010, "Anna", 100.0, 500.0);
         Console.WriteLine(account.Balance);
         */

        /*
        Account account = new Account(1001, "^Maria", 0.0);
        BusinessAccount busacc = new BusinessAccount(1002, "João", 0.0, 500.0);

        // UPCASTING

        Account acc1 = busacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Bob", 0.0, 0.01);

        // DOWNCASTING

        BusinessAccount acc4 = (BusinessAccount)acc2;

        acc4.Loan(100.0);

        if (acc3 is BusinessAccount)
        {
            BusinessAccount acc5 = (BusinessAccount)acc3;           
            acc5.Loan(200.0);
            Console.WriteLine("Loan");
        }

        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");

        }
        */
    }
}