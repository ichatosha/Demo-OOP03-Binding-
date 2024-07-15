using Demo_OOP03.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    public class Program
    {
        
        #region OverLoading 
        public static int Sum (int x, int y)
        {
            return x + y;
        }

        public static double Sum(double a , double b)
        {
            return a + b;
        }

        public static int Sum (int x , int y ,int z)
        {
            return x + y + z;
        }
        #endregion

        #region OverRiding


        #endregion


        public static void ProcessEmployee(Employee employee)
        {
            if(employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }

        public static void ProcessEmployee(FullTimeEmployee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeData();
                employee.GetEmployeeType();
            }
        }


        public static void ProcessEmployee(PartTimeEmployee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeData();
                employee.GetEmployeeType();
            }
        }
        static void Main(string[] args)
        {
            #region Polymorphism [OverLoading]
            int result = Sum(1,2);
            Console.WriteLine($"result : {result}");

            double resultD = Sum(1.5, 3.5);
            Console.WriteLine(resultD);

            int resultZ = Sum(1, 2, 3);
            Console.WriteLine(resultZ);

            #endregion

            #region Polymorphism [OberRiding]
            TypeA typeA = new TypeA(1);
            typeA.A = 155;
            typeA.PrintParent();
            typeA.PrintValue();

            TypeB typeB = new TypeB(1 , 5);
            typeB.A = 144;
            typeB.B = 163;
            typeB.PrintParent();
            typeB.PrintValue();

            #endregion

            #region Binding

            TypeA refBase;
            refBase = new TypeB(1, 2);
            refBase.A = 3;
            refBase.PrintValue();
            refBase.PrintParent();
            #endregion

            #region Not Binding 
            TypeB refChild =  (TypeB) new TypeA(2); // not binding - wxplicit casting

            TypeA typeA1 = new TypeB(1,6);
            TypeB TypeB1 = (TypeB) TypeA;

            Console.WriteLine(TypeB.A);
            Console.WriteLine(TypeB.B);
            #endregion

            #region Binding EX 01
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10 , "hesham" , 26 , 6000);
            ProcessEmployee(fullTimeEmployee);

            // initialize object : 
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Id = 20 ,
                Name = "Hesham",
                Age = 33,
                HourRate = 33M,
                CountHours = 20
            };

            ///partTimeEmployee.Id = 33;
            ///partTimeEmployee.Name = "hesham"; 
            ///partTimeEmployee.Age = 30;
            ///partTimeEmployee.CountHours = 444;
            ///partTimeEmployee.HourRate = 34M;
            
            ProcessEmployee(partTimeEmployee);
            #endregion

            #region Binding 02

            //TypeA for TypeC
            TypeA typeAC = new TypeC(1 ,2 , 3);
            typeAC.A = 12;
            //typeAC.B = 22;// Invalid
            //typeAC.c = 23;// Invalid
            typeAC.PrintParent();
            typeAC.PrintValue();

            //TypeB for TypeC
            TypeB typeBC = new TypeC(4, 5, 6);
            typeAC.A = 45;
            typeBC.B = 42;
            typeBC.PrintParent();
            typeBC.PrintValue();
            //typeBC.C = 43; // Invalid

            // TypeC for TypeC
            TypeC typeCC = new TypeC(7, 8, 9);
            typeCC.A = 13;
            typeCC.B = 14;
            typeCC.C = 15;
            typeCC.PrintValue();
            typeCC.PrintParent();

            TypeA typeAE = new TypeE(1,2,3,4,5);
            TypeB typeBE = new TypeE(1,2,3,4,5);
            TypeC typeCE = new TypeE(1,2,3,4,5);


            typeAE.PrintValue(); // dunamic bonded method 
            typeBE.PrintValue(); // dunamic bonded method 
            typeCE.PrintValue(); // dunamic bonded method 
            #endregion

        }
    }
}
