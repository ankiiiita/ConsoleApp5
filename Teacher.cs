using System;

namespace OOPDemo
{
    public class Teacher
    {
        // Property
        public string Name { get; set; }

        // Virtual method: can be overridden
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Sealed method: cannot be overridden by derived classes
        public void SalaryInfo()
        {
            Console.WriteLine("Salary info: 50,000 per month");
        }
    }
}
