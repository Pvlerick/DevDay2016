using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Singletons
{
    public static class PersonRepository
    {
        public static List<Person> GetAll()
        {
            return (from line in File.ReadAllLines("Data.txt")
                    let split = line.Split(',')
                    select new Person
                    {
                        Name = split[0],
                        DateOfBirth = DateTime.Parse(split[1]),
                        EmailAddress = split[2]
                    }).ToList();
        }
    }
}
