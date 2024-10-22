namespace ConsoleApp.src.OopPrinciples.Coupling
{
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            // Email sending logic
            Console.WriteLine("Sending email: " + message);
        }
    }
}