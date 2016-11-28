using System;
using System.IO;
using Xunit;

namespace Birthdays.Tests
{
    public class BirthdaysPrinterTest
    {
        //[Theory]
        //[InlineData("1988-11-29", "2016-11-29", 1)]
        //[InlineData("1988-11-29", "2016-11-28", 0)]
        //public void Print_CorrectlyPrintsBirthdays(string dob,
        //    string today, int expectedCount)
        //{
        //    // Fixture setup
        //    var persons = new[] {
        //        new Person { DateOfBirth = DateTime.Parse(dob) } };
        //    var output = new StringWriter();
        //    var sut = new BirthdaysPrinter();
        //    // Exercise system
        //    sut.Print(persons, DateTime.Parse(today), output);
        //    // Verify outcome
        //    var count = output.ToString()
        //        .Split(new[] { output.NewLine },
        //        StringSplitOptions.RemoveEmptyEntries)
        //        .Length;
        //    Assert.Equal(expectedCount, count);
        //    // Teardown 
        //}
    }
}
