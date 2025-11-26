using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a BankAccount object (Task 1)
                BankAccount myAccount = new BankAccount("ACC12345", 1000);

                // Display account number
                Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
                myAccount.Deposit(500);    // Valid deposit
                myAccount.Deposit(-100);   // Invalid deposit

                Console.WriteLine();

                // Withdraw money (Task 2)
                myAccount.Withdraw(300);   // Valid withdrawal
                myAccount.Withdraw(1500);  // Invalid withdrawal
                myAccount.Withdraw(-50);   // Invalid withdrawal

                Console.WriteLine($"\nFinal Balance: {myAccount.Balance:C}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
