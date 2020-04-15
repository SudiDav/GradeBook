using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrage = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrage = Math.Max(number, highGrage);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result = grades.Average();
            Console.WriteLine($"The average grade is {result:N2}");
            Console.WriteLine($"The hightest grade is {highGrage:N2}");
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
        }
    }
}