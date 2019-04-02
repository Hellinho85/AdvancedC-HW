using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv01
{
    public class UserService
    {
        private LoginService loginService = new LoginService();
        public int LoginChoice()
        {
            int UserChoice = 0;
            while (true)
            {
                Console.WriteLine("Enter your role please: ");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Trainer");
                Console.WriteLine("3. Student");
                bool isNumber = int.TryParse(Console.ReadLine(), out UserChoice);
                if (isNumber && UserChoice >= 1 && UserChoice <= 3)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return UserChoice;
        }

        public Person LoginForm(List<Person> database)
        {
            Person user;
            while (true)
            {
                Console.Write("Username:");
                string username = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();
                user = loginService.LogIn(username, password, database);
                if (user != null)
                {
                    break;
                }
                Console.WriteLine("Please try again: ");
                Console.ReadLine();
            }
            return user;
        }
        public int AdminChoice()
        {
            int adminChoice = 0;
            while (true)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                bool adNum = int.TryParse(Console.ReadLine(), out adminChoice);
                if (adNum && adminChoice > 0 && adminChoice < 3)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
            }
            return adminChoice;
        }

        public int TrainerChoice()
        {
            int trainerChoice = 0;
            while (true)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Show Students");
                Console.WriteLine("2. Show Subjects");
                bool isNumber = int.TryParse(Console.ReadLine(), out trainerChoice);
                if (isNumber && trainerChoice > 0 && trainerChoice < 3)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
            }
            return trainerChoice;
        }
        public int StudentChoice()
        {
            int studentChoice = 0;
            while (true)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Enrol Class");
                Console.WriteLine("2. Show Grades");
                bool isNumber = int.TryParse(Console.ReadLine(), out studentChoice);
                if (isNumber && studentChoice > 0 && studentChoice < 3)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
            }
            return studentChoice;
        }
        public int ChooseUser(List<Person> students)
        {
            int chooseUser = 0;
            while (true)
            {
                Console.WriteLine("Please choose: ");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {students[i].FirstName} {students[i].LastName}");
                }
                bool ChooseNum = int.TryParse(Console.ReadLine(), out chooseUser);
                if (ChooseNum && chooseUser > 0 && chooseUser < students.Count + 1)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
            }
            return chooseUser;
        }
        public int SubjectChoice(List<Subject> subjects)
        {
            int subChoice = 0;
            while (true)
            {
                Console.WriteLine("Please one:");
                for (int i = 0; i < subjects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {subjects[i].SubjectName}.");
                }
                bool isNumber = int.TryParse(Console.ReadLine(), out subChoice);
                if (isNumber && subChoice > 0 && subChoice < subjects.Count + 1)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
            }
            return subChoice;
        }
        public Person AddUser()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Username: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            int rolePick = 0;
            while (true)
            {
                Console.Write("Choose your Role: ");
                Console.Write("1. Admin");
                Console.Write("2. Trainer");
                Console.Write("3. Student");
                bool roleNum = int.TryParse(Console.ReadLine(), out rolePick);
                if (roleNum && rolePick > 0 && rolePick < 4)
                {
                    break;
                }
                Console.WriteLine("Invalid input. The input should be a number. Please try again!");
                Console.ReadLine();
                Console.Clear();
            }
            Role role = Role.Student;
            if (rolePick == 1) role = Role.Admin;
            if (rolePick == 2) role = Role.Trainer;
            return new Person(firstName, lastName, userName, password, role);
        }

        public void ShowStudents(List<Person> students)
        {
            Console.WriteLine("This is the complete list of all students: ");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}.");
            }
            Console.ReadLine();
        }

        public void ShowSubjects(List<Subject> subjects)
        {
            Console.WriteLine("This is the complete list of all subjects: ");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"{subject.SubjectName} ({subject.Enroll.Count} students). ");
            }
            Console.ReadLine();
        }

        public void PrintAllUsers(List<Person> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} - {user.Role}. ");
            }
        }
    }
}
