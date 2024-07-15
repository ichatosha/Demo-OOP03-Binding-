using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    internal class TypeB : TypeA
    {

        public int B { get; set; }


        public TypeB(int b ,int a) : base(a)
        {
            this.B = b;
        }

        public override void PrintParent()
        {
            Console.WriteLine($"iam the child");
        }

        public override void PrintValue()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }

    }
}
