using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Sudi's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The hightest grade is {stats.High:N1}");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The letter grade is {stats.letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    // Closing after the try catch
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A Grade was added!");
        }
    }
}
