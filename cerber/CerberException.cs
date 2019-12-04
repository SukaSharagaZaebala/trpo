using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.cerber
{
    class CerberException : Exception
    {
        public CerberException()
        {

        }

        public CerberException(string message) :
            base(message)
        {

        }
    }
}
