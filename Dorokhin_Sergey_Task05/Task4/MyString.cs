using System;

namespace Task4
{
    public class MyString
    {
        protected char[] _arrayOfChar;

        /*public MyString(char[] inputArrayOfChar)
        {
            inputArrayOfChar.CopyTo(_arrayOfChar, 0);
        }*/

        public MyString(string inputString)
        {
            _arrayOfChar = inputString.ToCharArray();
        }

        public char this[int index]
        {
            get
            {
                return _arrayOfChar[index];
            }
            set
            {
                _arrayOfChar[index] = value;
            }
        }

        public static MyString operator +(MyString myStringFirstOperand, MyString myStringSecondOperand)
        {
            return new MyString(myStringFirstOperand.ToString() + myStringSecondOperand.ToString());
        }

        public static MyString operator -(MyString myStringFirstOperand, MyString myStringSecondOperand)
        {
            return new MyString(myStringFirstOperand.ToString().Remove(myStringFirstOperand.ToString().
                IndexOf(myStringSecondOperand.ToString()), myStringSecondOperand.ToString().Length));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MyString myStringFirstOperand, MyString myStringSecondOperand)
        {
            return String.Compare(myStringFirstOperand.ToString(), 
                myStringSecondOperand.ToString()) == 0;
        }

        public static bool operator !=(MyString myStringFirstOperand, MyString myStringSecondOperand)
        {
            return String.Compare(myStringFirstOperand.ToString(), 
                myStringSecondOperand.ToString()) != 0;
        }

        public override string ToString()
        {
            return new string(_arrayOfChar);
        }

        public void SetString(string inputString)
        {
            _arrayOfChar = inputString.ToCharArray();
        }
    }
}
