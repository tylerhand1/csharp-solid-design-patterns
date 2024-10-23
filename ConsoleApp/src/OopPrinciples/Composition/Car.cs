namespace ConsoleApp.src.OopPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new();
        private Wheels wheels = new();
        private Chassis chassis = new();
        private Seats seats = new();

        public void StartCar()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
            Console.WriteLine("Car started");
        }
    }
}