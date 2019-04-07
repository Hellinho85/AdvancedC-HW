using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeworkAdv04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Event Publisher;
            Lecturer l = new Lecturer();

            // Event Subscribers;
            Student s1 = new Student("Gjorgji", "Kongulovski", 7);
            Student s2 = new Student("Riste", "Arsov", 8);
            Student s3 = new Student("Kristina", "Spasevska", 10);
            Student s4 = new Student("Kristijan", "Kitevski", 9);
            Student s5 = new Student("Dejan", "Kostic", 5);
            Student s6 = new Student("Todor", "Janevski", 5);
            Student s7 = new Student("Valentina", "Palkovska", 8);
            Student s8 = new Student("Andrijan", "Nikolovski", 5);
            Student s9 = new Student("Nikola", "Tabakovski", 6);
            Student s10 = new Student("Toshe", "Todorovski", 10);

            l.LecturerEvent += s1.GetStudentGrade;

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Hello Students! Here are the results of the final Exam: ");

            l.ReadGrades(s1.FirstName, s1.LastName, s1.Grade);
            l.ReadGrades(s2.FirstName, s2.LastName, s2.Grade);
            l.ReadGrades(s3.FirstName, s3.LastName, s3.Grade);
            l.ReadGrades(s4.FirstName, s4.LastName, s4.Grade);
            l.ReadGrades(s5.FirstName, s5.LastName, s5.Grade);
            l.ReadGrades(s6.FirstName, s6.LastName, s6.Grade);
            l.ReadGrades(s7.FirstName, s7.LastName, s7.Grade);
            l.ReadGrades(s8.FirstName, s8.LastName, s8.Grade);
            l.ReadGrades(s9.FirstName, s9.LastName, s9.Grade);
            l.ReadGrades(s10.FirstName, s10.LastName, s10.Grade);

            Console.ReadLine();

        }
    }
}
