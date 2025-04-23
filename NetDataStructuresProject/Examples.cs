using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDataStructuresProject
{
    static class Examples
    {
        public static void ClassExample()
        {
            Employee employee = new Employee();

            Person person = new() { Id = 10, Name = "Sammy" };

        }
    }

    //class Employee
    //{
    //    public string name;
    //    public int age;

    //    public Employee() : this("", 0) { }

    //    public Employee(string name) : this(name, 0) { }

    //    public Employee(int age) : this("", age) { }

    //    public Employee(string name, int age)
    //    {
    //        this.name = "Mr. " + name;
    //        this.age = age;
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"Name: {name}, Age: {age}");
    //    }
    //}

    class Employee(string name, int age)
    {
        public Employee() : this("", 0) { }
        public Employee(string name) : this(name, 0) { }

        public void ShowInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
