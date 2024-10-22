// Polymorphism

using ConsoleApp.src.OopPrinciples.Polymorphism;

List<Vehicle> vehicles = [];
vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });

foreach(var vehicle in vehicles)
{
    vehicle.Start();
}