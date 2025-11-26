using System;

namespace VehicleApp
{
    public class Car : Vehicle
    {
        // Unique field
        public int Seats { get; set; }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class info
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
