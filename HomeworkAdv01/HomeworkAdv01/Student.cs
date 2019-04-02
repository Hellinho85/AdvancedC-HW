using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv01
{
    public class Student : Person
    {
        public Dictionary<Subject, int> Grade { get; set; }
        public Subject Subject { get; set; }
        public Student(string firstName, string lastName, string userName, string password, Dictionary<Subject, int> grade, Subject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = Role.Student;
            Grade = grade;
            Subject = subject;
        }

        public void ShowGrade()
        {
            foreach (var grade in Grade)
            {
                Console.WriteLine($"{grade.Key.SubjectName}: {grade.Value}.");
            }
        }

        public void Enrolled(Subject currentSubject)
        {
            Subject = currentSubject;
        }

        public double GradeAverage()
        {
            double totalAverage = 0;
            foreach (var grades in Grade)
            {
                totalAverage += grades.Value;
            }

            return totalAverage / Grade.Count;

        }
    }
}
