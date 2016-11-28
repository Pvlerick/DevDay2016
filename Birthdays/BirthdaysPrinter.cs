using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Birthdays
{
    public sealed class BirthdaysPrinter
    {
        public void Print()
        {
            var persons = from line in File.ReadAllLines("Data.txt")
                          let split = line.Split(',')
                          select new Person
                          {
                              Name = split[0],
                              DateOfBirth = DateTime.Parse(split[1])
                          };

            Print(persons, DateTime.Today, Console.Out);
        }

        public void Print(IEnumerable<Person> persons,
            DateTime today, TextWriter output)
        {
            foreach (var person in persons)
            {
                if (person.DateOfBirth.Month == today.Month
                    && person.DateOfBirth.Day == today.Day)
                {
                    output.WriteLine($"Happy Birthday {person.Name}!");
                }
            }
        }
    }
}
