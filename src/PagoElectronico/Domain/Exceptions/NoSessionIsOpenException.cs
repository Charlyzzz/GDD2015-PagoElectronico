﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain.Exceptions
{
    [global::System.Serializable]
    public class NoSessionIsOpenException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NoSessionIsOpenException() { }
        public NoSessionIsOpenException(string message) : base(message) { }
        public NoSessionIsOpenException(string message, Exception inner) : base(message, inner) { }
        protected NoSessionIsOpenException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
