using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.7, 10.3, 6.11, 7.77 };
            grades.Add(56.1);

            System.Console.WriteLine(grades.Count);

            var result = 0.0;
            foreach (double number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            System.Console.WriteLine($"The average grade is {result:N2}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
