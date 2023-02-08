namespace contabanco.Entities
{
    //Herença(Extends)
    class BusinessAccount : Account
    {
        public double LoadLimit { get; set; }
        public BusinessAccount()
        {
        }
        /* Modo Simples
        public BusinessAccount(int number, string holder, double balance, double loadLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            LoadLimit = loadLimit;
        }
        */

        //Herança
        public BusinessAccount(int number, string holder, double balance, double loadLimit)
            : base(number, holder, balance)
        {
            LoadLimit = loadLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoadLimit)
            {
                Balance += amount;
            }

        }

    }
}
