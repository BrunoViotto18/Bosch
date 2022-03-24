using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX002
{
    class InvalidDataException : Exception
    {
        public InvalidDataException(string Message) : base(Message)
        {

        }
    }
}
