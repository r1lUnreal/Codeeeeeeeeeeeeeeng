﻿using System;
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
        Console.WriteLine($"Тип транспорта: {Name}, Скорость траспорта: {Speed} км/ч");
    }
}

class Car : Vehicle
{
    public Car(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} летит по трасе М1.");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} едет по воде.");
    }
}

class Boat : Vehicle
{
    public Boat(string name, double speed) : base(name, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} плывёт по тратуару.");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("BMW M4 G80/G82 RESTAILING", 240.0);
        Bicycle bicycle1 = new Bicycle("Крутой велик", 25.0);
        Boat boat1 = new Boat("Лодка с мотором", 55.0);

            car1.DisplayInfo();
            bicycle1.DisplayInfo();
            boat1.DisplayInfo();
            bicycle1.Move();
            car1.Move();
            boat1.Move();
            Console.WriteLine();
    }
}