using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyOverflowException : OverflowException
    {
        public MyOverflowException() { }
        public MyOverflowException(string message) : base(message) { }
        public MyOverflowException(string message, Exception inner) : base(message, inner) { }
        protected MyOverflowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
