// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numerical grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            char letterGrade;

            if (grade >= 90)
                letterGrade = 'A';
            else if (grade >= 80)
                letterGrade = 'B';
            else if (grade >= 70)
                letterGrade = 'C';
            else if (grade >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';

            Console.WriteLine($"The letter grade is: {letterGrade}");
        }
    }
}

