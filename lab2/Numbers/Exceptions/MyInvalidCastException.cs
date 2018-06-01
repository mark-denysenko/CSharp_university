using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyInvalidCastException : InvalidCastException
    {
        public MyInvalidCastException() { }
        public MyInvalidCastException(string message) : base(message) { }
        public MyInvalidCastException(string message, Exception inner) : base(message, inner) { }
        protected MyInvalidCastException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
