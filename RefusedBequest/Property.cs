using System;

namespace RefusedBequest
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }

    public class Employee : Person
    {

    }

    public class User : Person { }//we don't need Salary here!!
}
