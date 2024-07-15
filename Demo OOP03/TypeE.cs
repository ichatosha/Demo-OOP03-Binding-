using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    internal class TypeE : TypeD
    {
        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }

        public int E { get; set; }

        public new void PrintParent()
        {
            Console.WriteLine("iam Derived class From child grand child grand child");
        }

        public override void PrintValue()
        {
            Console.WriteLine($"typeC : a = {A} , b = {B} , c = {C},  d = {D} ,e = {E} ");
        }
    }
}
