using System;

namespace OOPDemo
{
    public class Smartphone : ElectronicDevice
    {
        public int BatteryLife { get; set; } // in hours

        public Smartphone(string brand, double price, int batteryLife)
            : base(brand, price)
        {
            BatteryLife = batteryLife;
        }

        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine($"{Brand} smartphone camera enabled.");
        }

        // Override ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone Brand: {Brand}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Battery Life: {BatteryLife} hours");
        }
    }
}
