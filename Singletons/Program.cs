using System;

namespace Singletons
{
    class Program
    {
        static void Main(string[] args)
        {
            var bes = new BirthdaysEmailSender();

            bes.Send(DateTime.Now);
        }
    }
}
