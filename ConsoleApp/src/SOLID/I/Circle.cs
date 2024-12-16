namespace ConsoleApp.src.SOLID.I
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area() => Math.PI * Math.Pow(Radius, 2);
    }
}