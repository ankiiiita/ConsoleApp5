//using System;

//namespace VehicleApp
//{
//    public class Car : Vehicle
//    {
//        // Unique field
//        public int Seats { get; set; }

//        // Override DisplayInfo
//        public override void DisplayInfo()
//        {
//            base.DisplayInfo(); // Call base class info
//            Console.WriteLine($"Seats: {Seats}");
//        }
//    }
//}


using System;

namespace OOPDemo
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}

