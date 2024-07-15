using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    internal class TypeA 
    {

        public int A { get; set; }


        public TypeA(int a)
        {
            this.A = a;
        }

        public virtual void PrintParent()
        {
            Console.WriteLine($"iam Base [Parent]");
        }

        public virtual void PrintValue()
        {
            Console.WriteLine($"TypeA  : A = {A}");
        }
    }
}
