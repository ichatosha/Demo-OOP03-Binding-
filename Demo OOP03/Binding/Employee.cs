using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Binding
{
    public class Employee
    {
        public Employee(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public Employee()
        {
            
        }
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetEmployeeType()
        {
            Console.WriteLine("Iam Employee");
        }

        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee : id = {Id} , name = {Name} , age = {Age}");
        }

    }
}
