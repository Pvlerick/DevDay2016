using System;

namespace Singletons
{
    public sealed class EmailSender : IEmailSender
    {
        private static readonly Lazy<EmailSender> lazy =
            new Lazy<EmailSender>(() => new EmailSender());

        public static EmailSender Instance => lazy.Value;

        private EmailSender() { }

        public void Send(string emailAddress, string message)
        {
            //Sends an email...
            System.Windows.Forms.MessageBox.Show($"{emailAddress}: {message}");
        }
    }
}