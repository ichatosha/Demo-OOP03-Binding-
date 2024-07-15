using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_OOP03.Binding
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee( int id , string name , int age, decimal salary) 
        {
            Salary = salary;
            Id = id;
            Name = name;
            Age = age;

        }

        public decimal Salary { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("iam Full time Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"FullTimeEmployee : id = {Id} , name = {Name} , age = {Age} , Salary = {Salary}" );
        }

    }

    

}
