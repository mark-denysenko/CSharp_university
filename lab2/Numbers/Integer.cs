
namespace Numbers
{
    class Integer : Number
    {
        private int number;
        public int Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }

        public Integer(int num)
        {
            number = num;
        }

        #region Overriding Object methods

        public override int GetHashCode()
        {
            return number;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            return number == (obj as Integer).number;
        }

        public override string ToString()
        {
            return number.ToString();
        }

        #endregion

        public override int ToInt()
        {
            return number;
        }

        public override double ToDouble()
        {
            return (double)number;
        }

        #region Realization basic functions

        public override Number Add(Integer n)
        {
            number += n.number;
            return new Integer(number);
        }
        public override Number Add(Real n)
        {
            number += n.ToInt();
            return new Integer(number);
        }
        public override Number Subtraction(Integer n)
        {
            number -= n.number;
            return new Integer(number);
        }
        public override Number Subtraction(Real n)
        {
            number -= n.ToInt();
            return new Integer(number);
        }
        public override Number Multiply(Integer n)
        {
            number *= n.number;
            return new Integer(number);
        }
        public override Number Multiply(Real n)
        {
            number *= n.ToInt();
            return new Integer(number);
        }
        public override Number Division(Integer n)
        {
            number /= n.number;
            return new Integer(number);
        }
        public override Number Division(Real n)
        {
            number /= n.ToInt();
            return new Integer(number);
        }

        #endregion

        #region Operators

        public static Integer operator +(Integer n1, Integer n2)
        {
            return new Integer(n1.Number + n2.Number);
        }
        public static Real operator +(Integer n1, Real n2)
        {
            return new Real(n1.number + n2.Number);
        }
        public static Integer operator -(Integer n1, Integer n2)
        {
            return new Integer(n1.Number - n2.Number);
        }
        public static Real operator -(Integer n1, Real n2)
        {
            return new Real(n1.Number - n2.Number);
        }
        public static Integer operator *(Integer n1, Integer n2)
        {
            return new Integer(n1.Number * n2.Number);
        }
        public static Real operator *(Integer n1, Real n2)
        {
            return new Real(n1.Number * n2.Number);
        }
        public static Integer operator /(Integer n1, Integer n2)
        {
            return new Integer(n1.Number / n2.Number);
        }
        public static Real operator /(Integer n1, Real n2)
        {
            return new Real(n1.Number / n2.Number);
        }

        #endregion
    }
}
