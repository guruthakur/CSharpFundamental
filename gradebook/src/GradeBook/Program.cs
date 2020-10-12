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
            book.ShowStatistics();
        }
    }
}