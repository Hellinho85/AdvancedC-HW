using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeworkAdv04
{
    public class Student
    {
        // Student properties;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        // Student constructor;
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        // Method for Student reactions regarding their Grades;
        public void GetStudentGrade(string firstName, string lastName, int grade)
        {
            if (grade > 5 && grade <= 10)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Student: {firstName} {lastName} quotes: " +
                    $"Awesome i passed the exam, party time!!!");
            }
            else if (grade == 5)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Student: {firstName} {lastName} quotes: " +
                    $"Damn i failed the exam, need to study hard all summer!!!");
            }
        }

    }
}
