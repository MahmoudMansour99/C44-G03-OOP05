using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeC : TypeB
    {
        #region Properties
        public int C { get; set; }
        #endregion

        #region Constructors
        public TypeC(int a, int b, int c):base(a, b)
        {
            C = c;
        }
        #endregion

        #region Methods
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 From GrandChild and I am Type C");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"this is MyFun02 from Grand Child and TypeA : A = {A}, TypeB: {B}, TypeC: {C}");
        }
        #endregion
    }
}
