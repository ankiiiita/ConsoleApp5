using System;

namespace OOPDemo
{
    public class Laptop : ElectronicDevice
    {
        public string Processor { get; set; }

        public Laptop(string brand, double price, string processor)
            : base(brand, price)
        {
            Processor = processor;
        }

        // Extra method
        public void TurnOnBattery()
        {
            Console.WriteLine($"{Brand} laptop battery turned on.");
        }

        // Override ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop Brand: {Brand}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Processor: {Processor}");
        }
    }
}
