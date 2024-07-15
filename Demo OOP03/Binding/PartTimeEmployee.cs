using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Binding
{
    public class PartTimeEmployee : Employee
    {

        public int CountHours { get; set; }

        public decimal HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("iam PartTime Employee ! ");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($" PartTimeEmployee : id  = {Id} , name = {Name} , age = {Age} , count of hours = {CountHours} , hour rate  = {HourRate} ");
        }
    }
}
