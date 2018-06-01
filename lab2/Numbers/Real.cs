using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Real : Number
    {
        private double number;
        private const double eps = 0.000001;

        public double Number
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

        public Real(double num)
        {
            number = num;
        }

        #region Overriding Object functions

        public override int GetHashCode()
        {
            //number.ToString().Split(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToArray<char>());
            return Convert.ToInt32(number.ToString().Replace(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, string.Empty));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            return this.GetHashCode() == (obj as Real).GetHashCode();
        }

        public override string ToString()
        {
            return number.ToString();
        }

        #endregion

        public override int ToInt()
        {
            return (int)number;
        }

        public override double ToDouble()
        {
            return number;
        }

        #region Realization of basics functions

        public override Number Add(Integer n)
        {
            number += n.Number;
            return new Real(number);
        }

        public override Number Add(Real n)
        {
            number += n.Number;
            return new Real(number);
        }

        public override Number Subtraction(Integer n)
        {
            number -= n.Number;
            return new Real(number);
        }

        public override Number Subtraction(Real n)
        {
            number -= n.Number;
            return new Real(number);
        }

        public override Number Multiply(Integer n)
        {
            number *= n.Number;
            return new Real(number);
        }

        public override Number Multiply(Real n)
        {
            number *= n.Number;
            return new Real(number);
        }

        public override Number Division(Integer n)
        {
            number /= n.Number;
            return new Real(number);
        }

        public override Number Division(Real n)
        {
            number /= n.Number;
            return new Real(number);
        }

        #endregion

        #region Operators

        public static Real operator + (Real n1, Real n2)
        {
            return new Real(n1.Number + n2.Number);
        }
        public static Real operator +(Real n1, Integer n2)
        {
            return new Real(n1.Number + n2.Number);
        }

        public static Real operator - (Real n1, Real n2)
        {
            return new Real(n1.Number - n2.Number);
        }
        public static Real operator -(Real n1, Integer n2)
        {
            return new Real(n1.Number - n2.Number);
        }

        public static Real operator * (Real n1, Real n2)
        {
            return new Real(n1.Number * n2.Number);
        }
        public static Real operator *(Real n1, Integer n2)
        {
            return new Real(n1.Number * n2.Number);
        }

        public static Real operator / (Real n1, Real n2)
        {
            return new Real(n1.Number / n2.Number);
        }
        public static Real operator /(Real n1, Integer n2)
        {
            return new Real(n1.Number / n2.Number);
        }

        #endregion
    }
}
