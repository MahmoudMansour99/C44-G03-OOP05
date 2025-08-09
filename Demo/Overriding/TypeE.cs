using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeE : TypeD
    {
        #region Properties
        public int E { get; set; }
        #endregion

        #region Constructors
        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }
        #endregion

        #region Methods
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 From Grand Grand Child and I am Type E");
        }
        public new void MyFun02()
        {
            Console.WriteLine($"this is MyFun02 from Grand Grand Child and TypeA : A = {A}, TypeB: {B}, TypeC: {C}, TypeD: {D}, TypeE: {E}");
        }
        #endregion
    }
}
