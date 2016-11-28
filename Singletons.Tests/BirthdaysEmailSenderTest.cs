using Moq;
using System;
using Xunit;

namespace Singletons.Tests
{
    public class BirthdaysEmailSenderTest
    {
        [Fact]
        public void Send_CorrectlySendsEmails()
        {
            // Fixture setup
            var personRepository = new Mock<IPersonRespository>();
            personRepository.Setup(s => s.GetAll()).Returns(
                new[] { new Person {
                    Name = "Gill Bates",
                    EmailAddress = "gill@apple.com",
                    DateOfBirth = DateTime.Parse("1955-10-29")
                }});
            var emailSender = new Mock<IEmailSender>();
            var sut = new BirthdaysEmailSender(personRepository.Object,
                emailSender.Object);
            // Exercise system
            sut.Send(DateTime.Parse("2016-10-29"));
            // Verify outcome
            emailSender.Verify(s => s.Send("gill@apple.com",
                "Happy Birthday Gill Bates"));
            // Teardown 
        }
    }
}
