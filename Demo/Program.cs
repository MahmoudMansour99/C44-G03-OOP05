using Demo.Overriding;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding
            // Reference from Parent [Base] => Object from Child [Derived]
            TypeA typeA = new TypeB(1, 2);
            typeA.A = 1;
            //typeA.B = 2; // Unreachable because we can see only the feild from the Referance 

            typeA.MyFun01(); // Static Polymorphism
                             // Static Binding
                             // Early Binding
                             // Compile Time Binding
                             // [Parent based on Reference]
            
            typeA.MyFun02(); // Dynamic Polymorphism
                             // Nonstatic Binding
                             // Late Binding
                             // Runtime Binding
                             // Child based on Object

            #endregion
        }
    }
}
