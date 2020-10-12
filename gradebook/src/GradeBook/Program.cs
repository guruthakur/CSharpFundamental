using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gurunath Grade book");
            book.AddGrade(59.9);
            book.AddGrade(86.9);
            book.AddGrade(17.9);
            var stats = book.GetStatistics();

            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The Highest grade is {stats.High}");
            Console.WriteLine($"The Average grade id {stats.Average:N1}");
        }
    }
}