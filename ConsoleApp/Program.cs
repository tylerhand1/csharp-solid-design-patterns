// LSP
using ConsoleApp.src.SOLID.L;

// var rect = new Square();
// rect.Height = 10;
// rect.Width = 5;
// Console.WriteLine("Expected area = 10 * 5 = 50");
// Console.WriteLine("Calculated area = " + rect.Area);

Shape rectangle = new Rectangle { Width = 5, Height = 4 };
Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

Shape square = new Square { SideLength = 5 };
Console.WriteLine($"Area of the square: {square.Area}");