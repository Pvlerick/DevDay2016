using System;
using System.Collections.Generic;

namespace Singletons
{
    public sealed class BirthdaysEmailSender
    {
        private readonly IEmailSender _emailSender;
        private readonly IPersonRespository _personRepository;

        public BirthdaysEmailSender() : this(new PersonRepositoryAdapter(),
            EmailSender.Instance)
        {

        }

        public BirthdaysEmailSender(IPersonRespository personRepository,
            IEmailSender emailSender)
        {
            _personRepository = personRepository;
            _emailSender = emailSender;
        }

        public void Send(DateTime today)
        {
            foreach (var person in _personRepository.GetAll())
            {
                if (IsBirthday(person, today))
                    _emailSender.Send(person.EmailAddress,
                        $"Happy Birthday {person.Name}");
            }
        }

        private bool IsBirthday(Person person, DateTime today)
        {
            return (person.DateOfBirth.Month == today.Month
                && person.DateOfBirth.Day == today.Day)
                || (DateTime.IsLeapYear(person.DateOfBirth.Year)
                    && !DateTime.IsLeapYear(today.Year)
                    && person.DateOfBirth.Month == 2
                    && person.DateOfBirth.Day == 29
                    && today.Month == 2
                    && today.Day == 28);
        }

        class PersonRepositoryAdapter : IPersonRespository
        {
            public IEnumerable<Person> GetAll() => PersonRepository.GetAll();
        }
    }
}
