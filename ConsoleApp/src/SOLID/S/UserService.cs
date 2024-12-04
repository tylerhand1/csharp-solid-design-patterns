namespace ConsoleApp.src.SOLID.S
{
    public class UserService
    {
        public void Register(User user)
        {
            // Register user logic...

            // Send email
            EmailSender emailSender = new();
            emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}