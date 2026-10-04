using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", 2024, 4);
            Bus myBus = new Bus("Mercedes", 2023, 50);
            Motorcycle myBike = new Motorcycle("Harley-Davidson", 2022, false);

            Console.WriteLine($"Car Brand: {myCar.Brand}, Year: {myCar.Year}, Doors: {myCar.NumberOfDoors}");
            myCar.Start();
            Console.WriteLine();

            Console.WriteLine($"Bus Brand: {myBus.Brand}, Year: {myBus.Year}, Capacity: {myBus.Capacity} passengers");
            myBus.Start();
            Console.WriteLine();

            Console.WriteLine($"Motorcycle Brand: {myBike.Brand}, Year: {myBike.Year}, Has Sidecar: {myBike.HasSidecar}");
            myBike.Start();
        }
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public virtual void Start()
        {
            Console.WriteLine($"The {Brand} vehicle is starting.");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int year, int numberOfDoors) : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;
        }
    }

    public class Bus : Vehicle
    {
        public int Capacity { get; set; }

        public Bus(string brand, int year, int capacity) : base(brand, year)
        {
            Capacity = capacity;
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
        {
            HasSidecar = hasSidecar;
        }
    }
}
