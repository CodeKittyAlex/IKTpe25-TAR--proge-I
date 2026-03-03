using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAllAny
{
    public class StudentData
    {
        public static readonly List<Student> students = new List<Student>()
        {
            new Student() {StudentId = 1, Name = "John", age = 13, StandardId = 1},
            new Student() {StudentId = 1, Name = "Moin", age = 21, StandardId = 1},
            new Student() {StudentId = 1, Name = "bill", age = 18, StandardId = 2},
            new Student() {StudentId = 1, Name = "Ram", age = 20, StandardId = 2},
            new Student() {StudentId = 1, Name = "Ron", age = 15},
        };
    }
}
