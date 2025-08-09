using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class Airplane : Vehicle, IMoveOnGround, IMoveOnAir
    {
        void IMoveOnGround.Backward()
        {
            Console.WriteLine("Move Backword on Ground");
        }

        void IMoveOnAir.Backward()
        {
            Console.WriteLine("Move Forward on Air");
        }

        void IMoveOnGround.Forward()
        {
            Console.WriteLine("Move Forward on Ground");
        }

        void IMoveOnAir.Forward()
        {
            Console.WriteLine("Move Forward on Air");
        }

        void IMoveOnGround.Left()
        {
            Console.WriteLine("Move Left on Ground");
        }

        void IMoveOnAir.Left()
        {
            Console.WriteLine("Move Left on Air");
        }

        void IMoveOnGround.Right()
        {
            Console.WriteLine("Move Right on Ground");
        }

        void IMoveOnAir.Right()
        {
            Console.WriteLine("Move Right on Air");
        }
    }
}
