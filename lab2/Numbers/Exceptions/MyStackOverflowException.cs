using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{

    [Serializable]
    public class MyStackOverflowException : SystemException
    {
        public MyStackOverflowException() { }
        public MyStackOverflowException(string message) : base(message) { }
        public MyStackOverflowException(string message, Exception inner) : base(message, inner) { }
        protected MyStackOverflowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
