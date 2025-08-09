using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; }
        #endregion

        #region Constructor
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        #endregion

        #region Methods
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 From Derived and I am Derived");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"this is MyFun02 from Derived and TypeA : A = {A}, TypeB: {B}");
        }
        #endregion
    }
}
