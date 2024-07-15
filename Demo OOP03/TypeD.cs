using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{

    // TypeD hase three parent (TypeA [indirect parent] + TypeB[indirect parent] + TypeC[direct parent])
    internal class TypeD : TypeC
    {
        public TypeD(int a,int b,int c,int d) : base(a,b,c)
        {
            D = d;
        }

        public int D { get; set; }

        public new void PrintParent()
        {
            Console.WriteLine("iam Derived [Child Grand Child] ");
        }

        // new => end  Sequence 
        // virtual => start new Sequence 
        public new virtual void PrintValue()
        {
            Console.WriteLine($"typeC : a = {A} , b = {B} , c = {C} d = {D}");
        }
    }
}
