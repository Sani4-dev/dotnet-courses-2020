using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class DynamicArrayEnumerator<T> : IEnumerator where T : class, new()
    {
        protected int position = -1;
        readonly T[] internalArray;

        public DynamicArrayEnumerator(T[] inputArray)
        {
            internalArray = inputArray;
        }

        public bool MoveNext()
        {
            if (position < internalArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= internalArray.Length)
                {
                    throw new InvalidOperationException();
                }

                return internalArray[position];
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
