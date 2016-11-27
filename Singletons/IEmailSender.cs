namespace Singletons
{
    public interface IEmailSender
    {
        void Send(string emailAddress, string message);
    }
}