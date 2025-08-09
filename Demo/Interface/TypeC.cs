using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class TypeC
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 5;
        }
    }
}
}
