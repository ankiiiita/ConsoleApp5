using System;

namespace BankApp
{
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Constructor to initialize account number and initial balance
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;

            if (initialBalance > 0)
                balance = initialBalance;
            else
                throw new ArgumentException("Initial balance must be greater than zero.");
        }

        // Public property: AccountNumber (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property: Balance (read-only outside, private set)
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance cannot be zero or negative.");
            }
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeds available balance.");
            }
        }
    }
}
