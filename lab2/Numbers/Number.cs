using System;

namespace Numbers
{
    abstract class Number : ICloneable
    {
        public abstract int ToInt();
        public abstract double ToDouble();

        public object Clone()
        {
            return this.MemberwiseClone();
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
