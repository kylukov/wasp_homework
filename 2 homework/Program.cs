using System;
using System.Diagnostics;
using System.IO.Pipes;

namespace MyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", 300, 2020);
        Console.WriteLine(car.ToString());
        Console.WriteLine();
        
        PassengerCar passcar = new PassengerCar("Bwm", 320, 2020, 20);
        passcar.AddToServiceBook(2020, "wheel");
        passcar.ShowServiceBook();
        passcar.ShowDetail("wheel");
        Console.WriteLine(passcar.ToString());
        Console.WriteLine();
        
        Truck truck = new Truck("Mersedes", 400, 2018, 3000, "Petrov Petr Petrovich", 100);
        truck.AddCargo("beer", 1000);
        truck.AddCargo("snacks", 1000);
        truck.ShowCargo();
        Console.WriteLine();
        truck.DeleteCargo("snacks");
        truck.ShowCargo();
        Console.WriteLine();
        Console.WriteLine(truck.ToString());
    }
}