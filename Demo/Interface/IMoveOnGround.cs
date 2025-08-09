using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface IMoveOnGround
    {
        public void Backward();
        public void Forward();
        public void Right();
        public void Left();
    }
}
