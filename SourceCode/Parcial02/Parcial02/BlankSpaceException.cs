using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    class BlankSpaceException : Exception
    {
        public BlankSpaceException(string message) : base(message)
        {
        }
    }
}
