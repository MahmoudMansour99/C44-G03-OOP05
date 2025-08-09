using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class Car : Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Move Backword on Ground");
        }

        public void Forward()
        {
            Console.WriteLine("Move Forward on Ground");
        }

        public void Left()
        {
            Console.WriteLine("Move Left on Ground");
        }

        public void Right()
        {
            Console.WriteLine("Move Right on Ground");
        }
    }
}
