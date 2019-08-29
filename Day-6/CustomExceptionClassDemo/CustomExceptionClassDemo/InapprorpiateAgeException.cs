using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionClassDemo
{
    class InapprorpiateAgeException : ApplicationException
    {
        private string message;
        public InapprorpiateAgeException()
        {

        }
        public InapprorpiateAgeException(string errorMessage)
            //:base(errorMessage)
        {
            message = errorMessage;
        }

        public override string Message => message;
    }
}
