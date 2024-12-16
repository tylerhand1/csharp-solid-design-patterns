namespace ConsoleApp.src.SOLID.I
{
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }
        public double Area() => 4 * Math.PI * Math.Pow(Radius, 2);

        public double Volume() => 4 / 3 * Math.PI * Math.Pow(Radius, 3);
    }
}