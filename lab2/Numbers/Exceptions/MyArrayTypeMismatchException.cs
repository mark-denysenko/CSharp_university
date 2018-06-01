using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyArrayTypeMismatchException : ArrayTypeMismatchException
    {
        public MyArrayTypeMismatchException() { }
        public MyArrayTypeMismatchException(string message) : base(message) { }
        public MyArrayTypeMismatchException(string message, Exception inner) : base(message, inner) { }
        protected MyArrayTypeMismatchException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
