using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain.Exceptions
{
    public class ValidatorException
    {
        public string Description { get; set; }

        public ValidatorException(string desc){
            Description = desc;
        }

    }
}
