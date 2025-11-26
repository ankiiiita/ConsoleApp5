using System;

namespace OOPDemo
{
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Constructor
        public ElectronicDevice(string brand, double price)
        {
            this.Brand = brand;
            this.Price = price;
        }

        // Properties (Encapsulation)
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

        // Abstract method
        public abstract void ShowInfo();
    }
}
