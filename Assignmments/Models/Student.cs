using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignmments.Models
{
    public class Student
    {
        public string FirstName = "";
        public string LastName = "";
        public double Grade;

        public Student()
        {

        }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
