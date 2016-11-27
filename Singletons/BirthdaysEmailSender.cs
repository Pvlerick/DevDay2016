using System;

namespace Singletons
{
    public sealed class BirthdaysEmailSender
    {
        public void Send(DateTime today)
        {
            foreach (var person in PersonRepository.GetAll())
            {
                if (IsBirthday(person, today))
                    EmailSender.Instance.Send(person.EmailAddress,
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
    }
}
