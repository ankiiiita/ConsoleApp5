using System;

namespace OOPDemo
{
    // Abstract class
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Constructor to initialize brand and price
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.Price = price; // Use property to validate
        }

        // Public properties (encapsulation)
        public string Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    brand = value;
                else
                    throw new ArgumentException("Brand cannot be empty.");
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("Price must be greater than zero.");
            }
        }

        // Abstract method: must be implemented by derived classes
        public abstract void ShowInfo();
    }
}
