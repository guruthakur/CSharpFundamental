using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 7.5, 23.5, 6.4 };
            grades.Add(56.3);
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The Average grade id {result:N1}");
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!!");
            }
            else
            {
                Console.WriteLine("Hello!!");
            }
        }
    }
}
