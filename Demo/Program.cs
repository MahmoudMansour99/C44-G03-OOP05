using Demo.Binding;
using Demo.Overriding;

namespace Demo
{
    internal class Program
    {
        public static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        static void Main(string[] args)
        {
            #region Binding
            #region Emaple 01
            // Reference from Parent [Base] => Object from Child [Derived]
            //TypeA typeA = new TypeB(1, 2);
            //typeA.A = 1;
            ////typeA.B = 2; // Unreachable because we can see only the feild from the Referance 

            //typeA.MyFun01(); // Static Polymorphism
            //                 // Static Binding
            //                 // Early Binding
            //                 // Compile Time Binding
            //                 // [Parent based on Reference]

            //typeA.MyFun02(); // Dynamic Polymorphism
            //                 // Nonstatic Binding
            //                 // Late Binding
            //                 // Runtime Binding
            //                 // Child based on Object
            #endregion

            #region Example 02
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10, "Ahmed", 25, 2000);
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee(10, "Ahmed", 25, 2, 5);
            //ProcessEmployee(partTimeEmployee);
            #endregion

            #region Example 03
            //TypeC typeC = new TypeC(1, 2, 3);
            //typeC.A = 10;
            //typeC.B = 20;
            //typeC.C = 30;
            //typeC.MyFun01();
            //typeC.MyFun02();

            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 10;
            ////typeA.B = 15; // Unreachable because we see only what we have inhirit from Reference
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 10;
            //typeB.B = 15;
            ////typeB.C = 15; // Unreachable because we see only what we have inhirit from Reference
            //typeB.MyFun01();
            //typeB.MyFun02();

            //TypeA typeA = new TypeD(1, 2, 3, 4);
            //typeA.A = 10;
            ////typeA.B = 15;
            ////typeA.C = 15; 
            ////typeA.D = 15; // Unreachable because we see only what we have inhirit from Reference
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeD(1, 2, 3, 4);
            //typeB.MyFun01();
            //typeB.MyFun02();

            //TypeC typeC = new TypeD(1, 2, 3, 4);
            //typeC.MyFun01();
            //typeC.MyFun02();

            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

   
            //typeA.MyFun02();


            //typeB.MyFun02();


            //typeC.MyFun02();

   
            //typeD.MyFun02();

            #endregion

            #endregion


        }
    }
}
