using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    // Dev 1
    internal interface IType
    {
        // 1. Signature for Properties
        public int MyProperty { get; set; } // Get and Set doesn't have any meaning

        // 2. Signature for Method
        public void MyMethod();

        // 3. Default Implemantated Method [C# 8.0]
        public void Print()
        {
            Console.WriteLine("Hello from Interface");
        }
    }
}
