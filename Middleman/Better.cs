using System;
using System.Collections.Generic;
using System.Text;

namespace Middleman.Better
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Department department = person.Department;
            person = department.GetManager();
        }
    }
    class Person
    {
        public Department Department { get; set; }
    }

    class Department
    {
        private readonly Person _manager;
        public Department(Person manager)
        {
            _manager = manager;
        }
        public Person GetManager()
        {
            return _manager;
        }

    }
}
