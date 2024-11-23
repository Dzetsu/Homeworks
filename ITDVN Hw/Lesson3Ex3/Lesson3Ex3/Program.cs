using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(230, 210, 140, 5000, "23.10.2023");
            Plane plane = new Plane(250, 625, 1000, 752, 80000, "10.04.2000", 108);
            Ship ship = new Ship(123, 52, 42, 420000, "28.02.2013", 5000, "Sevastopol");

            car.Show();
            plane.Show();
            ship.Show();
        }
    }

    class Vehicle
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public uint Speed { get; protected set; }
        public uint Price { get; protected set; }
        public string Date { get; protected set; }

        public Vehicle(int x, int y, uint speed, uint price, string date)
        {
            X = x;
            Y = y;
            Speed = speed;
            Price = price;
            Date = date;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Кординаты: ({X}, {Y})\n" +
                $"Скорость: {Speed}\n" +
                $"Цена: {Price}$\n" +
                $"Дата производства: {Date}\n\n");
        }
    }

    class Car : Vehicle 
    {
        public Car(int x, int y, uint speed, uint price, string date) : base(x, y, speed, price, date) { }
        
        public override void Show()
        {
            Console.WriteLine($"Кординаты: ({X}, {Y})\nСкорость: {Speed}\nЦена: {Price}$\nДата производства: {Date}\n\n");
        }
    }
    class Plane : Vehicle 
    { 
        public int Z { get; private set; }
        public uint Passengers { get; private set; }

        public Plane(int x, int y, int z, uint speed, uint price, string date, uint passengers) 
            : base(x, y, speed, price, date)
        {
            Z = z;
            Passengers = passengers;
        }
        public override void Show()
        {
            Console.WriteLine($"Кординаты: ({X}, {Y}, {Z})\n" +
                $"Скорость: {Speed}\n" +
                $"Цена: {Price}$\n" +
                $"Дата производства: {Date}\n" +
                $"Кол-во пассажиров: {Passengers}\n\n");
        }
    }
    class Ship : Vehicle
    {
        public uint Passengers { get; private set; }
        public string Registration { get; private set; }

        public Ship(int x, int y, uint speed, uint price, string date, uint passengers, string registration) 
            : base(x, y, speed, price, date)
        {
            Passengers = passengers;
            Registration = registration;
        }
        public override void Show()
        {
            Console.WriteLine($"Кординаты: ({X}, {Y})\n" +
                $"Скорость: {Speed}\n" +
                $"Цена: {Price}$\n" +
                $"Дата производства: {Date}\n" +
                $"Кол-во пассажиров: {Passengers}\n" +
                $"Регестрация: {Registration}\n\n");
        }
    }
}
