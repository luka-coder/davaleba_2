using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2
{
    class Student
    {
        private string first;
        private string last;
        private int age;

        private void Stud1(string first, string last, int age)
        {
            this.first = first;
            this.last = last;
            this.age = age;
        }
        public void Stud2(string first,string last,int age)
        {
            Stud1(first, last, age);
        }
        public void Stud3()
        {
            Console.Write("Student First Name: ");
            first = string.Format(Console.ReadLine());
            Console.Write("Student Last Name: ");
            last = string.Format(Console.ReadLine());
            Console.Write("Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Student First Name: {first}");
            Console.WriteLine($"Student Last Name: {last}");
            Console.WriteLine($"Student Age: {age}");
        }
    }
}
