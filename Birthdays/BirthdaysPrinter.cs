using System;
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

            foreach (var person in persons)
            {
                if (person.DateOfBirth.Month == DateTime.Now.Month
                    && person.DateOfBirth.Day == DateTime.Now.Day)
                {
                    Console.WriteLine($"Happy Birthday {person.Name}!");
                }
            }
        }
    }
}
