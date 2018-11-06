using System;
using System.Collections.Generic;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(ref int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {



            Arrays();
            //Immutable();
            //PassByValueAndRef();





            //GradeBook book = new GradeBook();
            //book.AddGrade(91);
            //book.AddGrade(89.5f);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach(float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;

        }

        private static void Immutable()
        {
            string name = " Scott ";
            name= name.Trim();

            DateTime date = new DateTime(2014, 1, 1);
            date = date.AddHours(25);

            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 10;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }
}
