using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktiki
{
    internal class Student
    {
        public string name;
        public string surname;
        public string email;
        public int age;


        public void GetFullName()
        {
            Console.WriteLine(name+ " " + surname);
        }

        public void GetFullData()
        {
            Console.WriteLine(name + " " + surname+ " " +email + " " + age);
        }

    }
}
