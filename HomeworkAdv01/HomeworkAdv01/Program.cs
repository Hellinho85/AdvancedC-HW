using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv01
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginService loginService = new LoginService();
            UserService userService = new UserService();

            List<Subject> SEDCAcademySubjects = new List<Subject>()
            {
                new Subject("HTML5 & CSS3"),
                new Subject("Basic Java Script"),
                new Subject("Advanced Java Script"),
                new Subject("Basic C#"),
                new Subject("Advanced C#")
            };

            List<Student> SEDCAcademyStudents = new List<Student>()
            {

                new Student("Gjorgji", "Kongulovski", "Hellinho", "thaboss", new Dictionary<Subject, int>(){
                    {SEDCAcademySubjects[0], 4 },
                    {SEDCAcademySubjects[1], 4 },
                    {SEDCAcademySubjects[2], 5 }
                }, SEDCAcademySubjects[3]),

                new Student("Riste", "Arsov", "ACMilan", "sansiro", new Dictionary<Subject, int>(){
                    {SEDCAcademySubjects[0], 4 },
                    {SEDCAcademySubjects[1], 5 },
                    {SEDCAcademySubjects[2], 1 }
                }, SEDCAcademySubjects[1]),

                new Student("Kristijan", "Kitevski", "Kitevac", "korca", new Dictionary<Subject, int>(){
                    {SEDCAcademySubjects[0], 1 },
                    {SEDCAcademySubjects[1], 4 },
                    {SEDCAcademySubjects[2], 2 }
                }, SEDCAcademySubjects[2]),

                new Student("Valentina", "Palkovska", "Palkovica", "palka", new Dictionary<Subject, int>(){
                    {SEDCAcademySubjects[0], 3 },
                    {SEDCAcademySubjects[1], 4 },
                    {SEDCAcademySubjects[2], 1 }
                }, SEDCAcademySubjects[4]),
            };

            SEDCAcademySubjects[0].Enroll = new List<Student>() { SEDCAcademyStudents[0], SEDCAcademyStudents[2] };
            SEDCAcademySubjects[1].Enroll = new List<Student>() { SEDCAcademyStudents[0], SEDCAcademyStudents[2] };
            SEDCAcademySubjects[2].Enroll = new List<Student>() { SEDCAcademyStudents[0], SEDCAcademyStudents[1], SEDCAcademyStudents[2] };
            SEDCAcademySubjects[3].Enroll = new List<Student>() { SEDCAcademyStudents[0], SEDCAcademyStudents[1] };
            SEDCAcademySubjects[4].Enroll = new List<Student>() { SEDCAcademyStudents[0], SEDCAcademyStudents[1] };

            Student currentStudent = null;
            List<Person> usersDB = new List<Person>()
            {
                SEDCAcademyStudents[0],
                SEDCAcademyStudents[1],
                SEDCAcademyStudents[2],
                SEDCAcademyStudents[3],

                new Person("Ana", "Ivanovic", "Anka", "frenchy", Role.Admin),

                new Person("Aracely", "Arambula", "ManEater", "divina", Role.Admin),

                new Person("Vekoslav", "Stefanovski", "Veko", "iluvcode", Role.Trainer),

                new Person("Dragan", "Gelevski", "Drakso", "draxmax", Role.Trainer),

                new Person("Risto", "Panchevski", "Riki", "decimotercera", Role.Trainer),

                new Person("Trajan", "Stevkovski", "Trale", "ilovearsenal", Role.Trainer),

                new Person("Marjan", "Pusev", "Macko", "funz", Role.Trainer),

                new Person("Dejan", "Zdravkovski", "Deki", "coolidge", Role.Trainer)
            };

            int roleChoice = userService.LoginChoice();
            Person loggedIn = userService.LoginForm(usersDB);
            if (loggedIn.Role == Role.Student) currentStudent = SEDCAcademyStudents.Where
                    (x => x.UserName == loggedIn.UserName).FirstOrDefault();


            int userChoice = 0;
            switch (roleChoice)
            {
                case 1:
                    while (true)
                    {
                        Console.Clear();
                        userChoice = userService.AdminChoice();
                        if (userChoice == 1)
                        {
                            Console.WriteLine("Enter the necessary information regarding the User:");
                            Person newUser = userService.AddUser();
                            usersDB.Add(newUser);
                            if (newUser.Role == Role.Student) SEDCAcademyStudents.Add((Student)newUser);
                            Console.WriteLine("User added!");
                            Console.ReadLine();
                            break;
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("Enter the necessary information regarding the User you want to remove: ");
                            string username = Console.ReadLine();
                            Person found = usersDB.Where(x => x.UserName == username).FirstOrDefault();
                            bool removed = usersDB.Remove(found);
                            if (found != null && found.Role == Role.Student)
                            {
                                SEDCAcademyStudents.Remove(SEDCAcademyStudents.Where(x => x.UserName == username).FirstOrDefault());
                            }
                            if (removed) Console.WriteLine("The User has been removed!");
                            else Console.WriteLine("Such User does not exist!");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct number: ");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    while (true)
                    {
                        Console.Clear();
                        userChoice = userService.TrainerChoice();
                        if (userChoice == 1)
                        {
                            userService.ShowStudents(usersDB.Where(x => x.Role == Role.Student).ToList());
                            break;
                        }
                        else if (userChoice == 2)
                        {
                            userService.ShowSubjects(SEDCAcademySubjects);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct number: ");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    userChoice = userService.StudentChoice();
                    while (true)
                    {
                        if (userChoice == 1)
                        {
                            Console.WriteLine("Enroll in a subject you like :");
                            int studentChoice = userService.SubjectChoice(SEDCAcademySubjects);
                            currentStudent.Enrolled(SEDCAcademySubjects[studentChoice - 1]);
                            SEDCAcademySubjects[studentChoice - 1].Enroll.Add(currentStudent);
                            Console.WriteLine($"You have enroled in {SEDCAcademySubjects[studentChoice - 1].SubjectName}!");
                            break;
                        }
                        else if (userChoice == 2)
                        {
                            currentStudent.ShowGrade();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please correct number: ");
                            Console.ReadLine();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("ERROR! Restart and try again!");
                    Console.ReadLine();
                    return;
            }
            Console.ReadLine();
        }
    }
}
