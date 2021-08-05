using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCULib.Exceptions
{
    class RiotClientUnauthorizedException : Exception
    {
        public RiotClientUnauthorizedException(string msg) : base(msg)
        {

        }
    }
}
