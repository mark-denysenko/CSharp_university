using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Exceptions
{
    [Serializable]
    public class MyIndexOutOfRangeException: SystemException
    {
        public MyIndexOutOfRangeException() { }
        public MyIndexOutOfRangeException(string message) : base(message) { }
        public MyIndexOutOfRangeException(string message, Exception inner) : base(message, inner) { }
        protected MyIndexOutOfRangeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
