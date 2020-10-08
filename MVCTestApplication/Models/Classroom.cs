using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestApplication.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string TeacherName { get; set; }
        public IEnumerable<Student> students { get; set; }
    }
}
