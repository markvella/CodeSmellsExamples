using System;

namespace Middleman.Bad
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person = person.GetManager();
        }
    }


    class Person
    {
        public Department Department { get; set; }
        public Person GetManager()
        {
            return Department.GetManager();
        }
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
