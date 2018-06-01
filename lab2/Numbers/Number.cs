using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    abstract class Number
    {
        public abstract int ToInt();
        public abstract double ToDouble();

        public virtual Number Copy()
        {
            return (Number)this.MemberwiseClone();
        }

        #region Basic functions (abstract)

        public abstract Number Add(Integer n);
        public abstract Number Add(Real n);
        public abstract Number Subtraction(Integer n);
        public abstract Number Subtraction(Real n);
        public abstract Number Multiply(Integer n);
        public abstract Number Multiply(Real n);
        public abstract Number Division(Integer n);
        public abstract Number Division(Real n);

        #endregion

        public static bool operator == (Number n1, Number n2)
        {
            return n1.Equals(n2);
        }

        public static bool operator != (Number n1, Number n2)
        {
            return !(n1.Equals(n2));
        }
    }
}
