using System;

namespace Bank_Project
{
    public class BankAccount
    {
        private readonly string p_bankName;
        private readonly string p_accountOwner;
        private readonly string p_accountName;
        private readonly string p_accountType; // checkingAccount, investmentIndividualAccount, investmentCorporateAccount
        private int p_accountBalance;

        private BankAccount() { }

        public BankAccount(string bankName, string accountOwner, string accountName, string accountType, int accountBalance)
        {
            p_bankName = bankName;
            p_accountOwner = accountOwner;
            p_accountName = accountName;
            p_accountType = accountType;
            p_accountBalance = accountBalance;
        }

        public string BankName
        {
            get { return p_bankName; }
        }
        public string AccountOwner
        {
            get { return p_accountOwner; }
        }
        public string AccountName
        {
            get { return p_accountName; }
        }
        public string AccountType
        {
            get { return p_accountType; }
        }
        public int AccountBalance
        {
            get { return p_accountBalance; }
        }

        public void Deposit(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            amount += p_accountBalance;
        }

        public void Withdraw(int amount)
        {
            if (amount > p_accountBalance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            amount -= p_accountBalance;
        }

        public static void Main()
        {
            BankAccount thisAccount = new BankAccount("Bank of Jobs", 
                                                      "Recruiter People",
                                                      "Money Account",
                                                      "checkingAccount",
                                                       300);

            //Console.WriteLine("Welcome to {0}", thisAccount.BankName);
            //Console.WriteLine("Hello, {0}", thisAccount.AccountOwner);
            //Console.WriteLine("Current balance is ${0}", thisAccount.AccountBalance);

            //thisAccount.Withdraw(90);
            //Console.WriteLine("Withdraw: Current balance is ${0}", thisAccount.AccountBalance);

            //thisAccount.Deposit(100);
            //Console.WriteLine("Deposit: Current balance is ${0}", thisAccount.AccountBalance);

        }
    }
}
