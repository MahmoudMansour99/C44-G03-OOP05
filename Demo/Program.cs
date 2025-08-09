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

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(10, "Ahmed", 25, 2, 5);
            ProcessEmployee(partTimeEmployee);
            #endregion
            #endregion
        }
    }
}
