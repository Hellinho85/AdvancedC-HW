using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeworkAdv04
{
    public class Lecturer
    {
        // EventHandler Delegate;
        public delegate void LecturerEventHandler(string firstName, string lastName, int grade);

        // EventHandler;
        public event LecturerEventHandler LecturerEvent;

        // Method for Trainer reading the Grades of Students with included EventHandler;
        public void ReadGrades(string firstName, string lastName, int grade)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Thread.Sleep(5000);
            Console.WriteLine($"Student: {firstName} {lastName}, Grade: {grade}!");
            LecturerEvent(firstName, lastName, grade);
        }

    }
}
