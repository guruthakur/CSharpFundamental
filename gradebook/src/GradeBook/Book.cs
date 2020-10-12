using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        private List<double> grades;

        public void ShowStatistics()
        {
            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number,lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The Lowest grade is {lowGrade}");
            Console.WriteLine($"The Highest grade is {highGrade}");
            Console.WriteLine($"The Average grade id {result:N1}");
        }
        private string name;

    }
}