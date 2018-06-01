using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyDivideByZeroException : DivideByZeroException
    {
        public MyDivideByZeroException() { }
        public MyDivideByZeroException(string message) : base(message) { }
        public MyDivideByZeroException(string message, Exception inner) : base(message, inner) { }
        protected MyDivideByZeroException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
