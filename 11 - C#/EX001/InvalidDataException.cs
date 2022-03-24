using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string Message) : base(Message)
        {

        }
    }
}
