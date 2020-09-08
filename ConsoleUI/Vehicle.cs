using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); // stubbed out method (means it has no implementation)

        public virtual void DriveVirtual() // does have implementation and scope - virtual method
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive"); // has implention and scope - virtual method
        } // has implention and scope -  virtual method
    }

}
