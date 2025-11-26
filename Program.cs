////using System;

////namespace BankApp
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            try
////            {
////                // Create a BankAccount object (Task 1)
////                BankAccount myAccount = new BankAccount("ACC12345", 1000);

////                // Display account number
////                Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
////                Console.WriteLine($"Initial Balance: {myAccount.Balance:C}\n");

////                // Deposit money (Task 2)
////                myAccount.Deposit(500);    // Valid deposit
////                myAccount.Deposit(-100);   // Invalid deposit

////                Console.WriteLine();

////                // Withdraw money (Task 2)
////                myAccount.Withdraw(300);   // Valid withdrawal
////                myAccount.Withdraw(1500);  // Invalid withdrawal
////                myAccount.Withdraw(-50);   // Invalid withdrawal

////                Console.WriteLine($"\nFinal Balance: {myAccount.Balance:C}");
////            }
////            catch (ArgumentException ex)
////            {
////                Console.WriteLine($"Error: {ex.Message}");
////            }
////        }
////    }
////}







//using System;

//namespace VehicleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create Car object
//            Car myCar = new Car()
//            {
//                Brand = "Toyota",
//                Speed = 180,
//                Seats = 5
//            };

//            // Create Motorcycle object
//            Motorcycle myMotorcycle = new Motorcycle()
//            {
//                Brand = "Honda",
//                Speed = 120,
//                HasCarrier = true
//            };

//            // Demonstrate base class methods
//            myCar.Start();
//            myCar.DisplayInfo();
//            myCar.Stop();

//            Console.WriteLine();

//            myMotorcycle.Start();
//            myMotorcycle.DisplayInfo();
//            myMotorcycle.Stop();
//        }
//    }
//}


using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Printer object
            Printer printer = new Printer();

            // Call overloaded Print methods
            printer.Print("Hello, World!");   // Prints a string
            printer.Print(2025);              // Prints an integer
            printer.Print("Repeat this", 3);  // Prints the message 3 times
        }
    }
}


