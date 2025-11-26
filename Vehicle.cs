//using System;

//namespace VehicleApp
//{
//    // Base class
//    public class Vehicle
//    {
//        // Properties
//        public string Brand { get; set; }
//        public int Speed { get; set; }

//        // Methods
//        public void Start()
//        {
//            Console.WriteLine($"{Brand} is starting.");
//        }

//        public void Stop()
//        {
//            Console.WriteLine($"{Brand} is stopping.");
//        }

//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Brand: {Brand}");
//            Console.WriteLine($"Speed: {Speed} km/h");
//        }
//    }
//}



using System;

namespace OOPDemo
{
    // Abstract class
    public abstract class Vehicle
    {
        // Abstract methods
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
