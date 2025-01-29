using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string Name { get; set; }
    public double Speed { get; set; }

    public Vehicle(string name, double speed)
    {
        Name = name;
        Speed = speed;
    }

    public abstract void Move();

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Скорость: {Speed} км/ч");
    }
}

class Car : Vehicle
{
    public Car(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} едет по дороге.");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} едет по тротуару.");
    }
}

class Boat : Vehicle
{
    public Boat(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} плывёт по воде.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Car("Легковой автомобиль", 120.0);
        Vehicle bicycle = new Bicycle("Горный велосипед", 25.0);
        Vehicle boat = new Boat("Катер", 55.0);

        List<Vehicle> vehicles = new List<Vehicle> { car, bicycle, boat };
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            vehicle.Move();
            Console.WriteLine();
        }
    }
}