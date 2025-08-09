using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overriding
{
    internal class TypeA
    {
        #region Properties
        public int A { get; set; }
        #endregion

        #region Constructor
        public TypeA(int a)
        {
            A = a;
        }
        #endregion

        #region Methods
        public void MyFun01()
        {
            Console.WriteLine("This is MyFun01 From Base and I am Base");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"this is MyFun02 from Base and TypeA : A = {A}");
        }
        #endregion
    }
}
