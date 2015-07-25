using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain.Exceptions
{
    class MissingConfigFieldException : Exception
    {
        public string Field { set; get; }

        public MissingConfigFieldException(string field)
        {
            Field = field;
        }
    }
}
