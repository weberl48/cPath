using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Bob's gradebook";
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(33);
            book.AddGrade(87);
            book.AddGrade(66);
            book.AddGrade(75);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.Read();
        }
    }
}
