// LSP
using ConsoleApp.src.SOLID.L;

var rect = new Square();
rect.Height = 10;
rect.Width = 5;
Console.WriteLine("Expected area = 10 * 5 = 50");
Console.WriteLine("Calculated area = " + rect.Area);