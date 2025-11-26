using System;

namespace VehicleApp
{
    public class Motorcycle : Vehicle
    {
        // Unique field
        public bool HasCarrier { get; set; }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class info
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
