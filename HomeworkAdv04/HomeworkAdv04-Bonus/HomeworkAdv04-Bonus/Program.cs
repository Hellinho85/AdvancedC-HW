using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeworkAdv04_Bonus
{
    class Program
    {
        public delegate void Lecturer(string firstName, string lastName, int grade);
        public delegate void Student(string firstName, string lastName, int grade);

        static void Main(string[] args)
        {
            Lecturer t1 = new Lecturer(GetTrainerInfo);
            t1("Gjorgji", "Kongulovski", 10);
            Student s1 = new Student(GetStudentInfo);
            s1("Gjorgji", "Kongulovski", 10);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Lecturer t2 = new Lecturer(GetTrainerInfo);
            t2("Riste", "Arsov", 9);
            Student s2 = new Student(GetStudentInfo);
            s2("Riste", "Arsov", 9);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Lecturer t3 = new Lecturer(GetTrainerInfo);
            t3("Toshka", "Membranac", 5);
            Student s3 = new Student(GetStudentInfo);
            s3("Toshka", "Membranac", 5);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Lecturer t4 = new Lecturer(GetTrainerInfo);
            t3("Kristijan", "Kitevski", 8);
            Student s4 = new Student(GetStudentInfo);
            s3("Kristijan", "Kitevski", 8);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Lecturer t5 = new Lecturer(GetTrainerInfo);
            t3("Dejan", "Kostic", 5);
            Student s5 = new Student(GetStudentInfo);
            s3("Dejan", "Kostic", 5);
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.ReadLine();
        }

        public static void GetTrainerInfo(string firstName, string lastName, int grade)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"FullName: {firstName} {lastName}, Grade: {grade}.");
        }

        public static void GetStudentInfo(string firstName, string lastName, int grade)
        {
            if (grade > 5 && grade <= 10)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"FullName: {firstName} {lastName} quotes: " +
                    $"Awesome i passed the exam, party time!!!");
            }
            else if (grade == 5)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"FullName: {firstName} {lastName} quotes: " +
                    $"Damn i failed the exam, time to hit the books and study really hard!!!");
            }

        }
    }
}
