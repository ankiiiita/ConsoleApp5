using System;
using System.Collections.Generic;

namespace OOPDemo
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices;

        public ElectronicsStore()
        {
            devices = new List<ElectronicDevice>();
        }

        // Add device
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to store.");
        }

        // Remove device
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
                Console.WriteLine($"{device.Brand} removed from store.");
            else
                Console.WriteLine($"{device.Brand} not found in store.");
        }

        // Show all device details and child-specific behavior
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n--- Store Device Details ---\n");

            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcast to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
