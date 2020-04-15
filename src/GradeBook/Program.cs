using System.Linq;
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sudi's Grade Book");
            book.AddGrade(89.9);
            book.AddGrade(91.9);
            book.AddGrade(79.9);
            book.ShowStatistics();
        }
    }
}
