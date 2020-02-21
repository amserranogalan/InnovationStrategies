using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnovationStrategies
{
    class DriverExistsException : Exception
    {

        public DriverExistsException()
        {
        }

        public DriverExistsException(string message) : base(message)
        {
        }
    }
}
