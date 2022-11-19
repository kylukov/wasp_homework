using System;
using System.Diagnostics;

namespace MyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", 300, 2020);
        Console.WriteLine(car.ToString());
    }
}