namespace contabanco.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //Modificador de acesso
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //
        /*
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        */
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //Para métado comum (bão abstrato) possa ser sobreposto,
        // deve ser incluído nele o prefixo "virtual"
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0; //Saque com taxa
        }
    }
}
