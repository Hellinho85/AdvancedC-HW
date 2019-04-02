using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv01
{
    public class LoginService
    {
        public Person LogIn(string userName, string password, List<Person> users)
        {
            try
            {
                var check = users.Where(x => x.UserName == userName).First();
                return check;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("That User does not exist in this DataBase!");
                return null;
            }
        }
    }
}
