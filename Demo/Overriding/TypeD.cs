using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeD : TypeC
    {
        #region Properties
        public int D { get; set; }
        #endregion

        #region Constructors
        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }
        #endregion

        #region Methods
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 From Grand Grand Child and I am Type D");
        }
        public new void MyFun02()
        {
            Console.WriteLine($"this is MyFun02 from Grand Grand Child and TypeA : A = {A}, TypeB: {B}, TypeC: {C}, TypeD: {D}");
        }
        #endregion
    }
}
