using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCULib.Exceptions
{
    public class RiotClientExceptions : Exception
    {
        public RiotClientExceptions(string msg) : base(msg)
        {

        }
      
    }
}
