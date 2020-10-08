using MVCTestApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestApplication.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var studentList = new List<Student>{
                            new Student() {FirstName = "John", LastName = "Doe", Age = 18, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Steve",LastName = "Doe", Age = 21, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Bill", LastName = "Doe", Age = 25, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Ram" , LastName = "Doe", Age = 20, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Ron" , LastName = "Doe", Age = 31, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Chris", LastName = "Doe",Age = 17, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } ,
                            new Student() {FirstName = "Rob" , LastName = "Doe", Age = 19, GPA= 3.7, Address = "1800 N 3400 E, Strange Road, MY" } };

            foreach (Student s in studentList)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

        }
    }
}
