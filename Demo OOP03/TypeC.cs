using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{

    // typeC -> Direct Parent  (TypeB)
    // typeC -> indirect Parent (typeA)

    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }

        public override void PrintParent()
        {
            Console.WriteLine("iam the child of the child [TypeB]");
        }

        public override void PrintValue()
        {
            Console.WriteLine($"typeC : a = {A} , b = {B} , c = {C}");

        }

    }
}
