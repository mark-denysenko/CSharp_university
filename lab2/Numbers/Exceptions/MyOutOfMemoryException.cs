using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyOutOfMemoryException : OutOfMemoryException
    {
        public MyOutOfMemoryException() { }
        public MyOutOfMemoryException(string message) : base(message) { }
        public MyOutOfMemoryException(string message, Exception inner) : base(message, inner) { }
        protected MyOutOfMemoryException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
