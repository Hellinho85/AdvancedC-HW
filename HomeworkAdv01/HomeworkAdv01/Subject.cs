using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv01
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public List<Student> Enroll { get; set; }
        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }
    }
}
