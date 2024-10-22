namespace ConsoleApp.src.OopPrinciples.Coupling
{
    public class Order
    {
        public void PlaceOrder()
        {
            // Place order logic
            EmailSender emailSender = new();
            emailSender.SendEmail("Order placed successfully");
        }
    }
}