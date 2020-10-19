using System;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    public class DynamicArray<T> where T : class, new()
    {
        protected const int lengthArrayDefault = 8;
        
        protected T[] _arrayOfT;
        protected int _indexElementOfArrayToAdditing = 0;

        public DynamicArray()
        {
            _arrayOfT = new T[lengthArrayDefault];
        }

        public DynamicArray(int lengthOfArray)
        {
            if (lengthOfArray == 0)
            {
                throw new Exception("Аргумент \"lengthOfArray\" должен быть больше 0!");
            }
            _arrayOfT = new T[lengthOfArray];
        }

        public DynamicArray(T[] arrayOfT)
        {
            _arrayOfT = arrayOfT ?? throw new Exception("Аргумент конструктора не должен быть равен \"NULL\"");
            foreach (var item in arrayOfT)
            {
                if (item == null)
                {
                    throw new Exception("Передаваемый массив должен быть полностью заполнен!");
                }
            }
            _indexElementOfArrayToAdditing += arrayOfT.Length;
        }

        public void Add(T objectToAdd)
        {
            if (_indexElementOfArrayToAdditing > _arrayOfT.Length - 1)
            {
                Array.Resize(ref _arrayOfT, _arrayOfT.Length * 2);
            }

            _arrayOfT[_indexElementOfArrayToAdditing] = objectToAdd ?? throw new Exception("Аргумент метода не должен быть равен \"NULL\"");
            _indexElementOfArrayToAdditing++;
        }

        public void AddRange(T[] arrayOfT)
        {
            if (arrayOfT == null)
            {
                throw new Exception("Аргумент метода не должен быть равен \"NULL\"");
            }

            foreach (var item in arrayOfT)
            {
                if (item == null)
                {
                    throw new Exception("Передаваемый массив должен быть полность заполнен!");
                }
            }

            int quantityEmptyElementsOfArray = _arrayOfT.Length - _indexElementOfArrayToAdditing;

            if (arrayOfT.Length > quantityEmptyElementsOfArray)
            {
                Array.Resize(ref _arrayOfT, arrayOfT.Length - quantityEmptyElementsOfArray + _arrayOfT.Length);
            }

            arrayOfT.CopyTo(_arrayOfT, _indexElementOfArrayToAdditing);
            _indexElementOfArrayToAdditing += arrayOfT.Length;
        }

        public bool Remove(int indexOf)
        {
            if (_indexElementOfArrayToAdditing == 0 || indexOf > _indexElementOfArrayToAdditing - 1)
            {
                return false;
            }
            else
            {
                if (indexOf == _indexElementOfArrayToAdditing - 1)
                {
                    _indexElementOfArrayToAdditing--;
                }
                else if(indexOf < _indexElementOfArrayToAdditing - 1)
                {
                    T[] arrayHelper = new T[_indexElementOfArrayToAdditing - indexOf];

                    Array.ConstrainedCopy(_arrayOfT, indexOf + 1, arrayHelper, 0, _indexElementOfArrayToAdditing - 1 -indexOf);
                    arrayHelper.CopyTo(_arrayOfT, indexOf);
                    _indexElementOfArrayToAdditing--;
                }

                return true;
            }
        }

        public void Insert(int indexTo, T objectToInsert)
        {
            if (objectToInsert == null)
            {
                throw new Exception("Передаваемый объект не должен быть равен \"NULL\"!");
            }
            
            if (indexTo > _indexElementOfArrayToAdditing - 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            Array.Resize(ref _arrayOfT, _indexElementOfArrayToAdditing + 1);

            if (indexTo == _indexElementOfArrayToAdditing - 1)
            {
                _arrayOfT[_indexElementOfArrayToAdditing] = objectToInsert;
            }
            else
            {
                T[] arrayHelper = new T[_indexElementOfArrayToAdditing - indexTo];

                Array.ConstrainedCopy(_arrayOfT, indexTo, arrayHelper, 0, _indexElementOfArrayToAdditing - indexTo);
                arrayHelper.CopyTo(_arrayOfT, indexTo + 1);
                _arrayOfT[indexTo] = objectToInsert;
            }

            _indexElementOfArrayToAdditing++;
        }

        public int Length
        {
            get
            {
                return _indexElementOfArrayToAdditing;
            }
        }

        public int Capacity
        {
            get
            {
                return _arrayOfT.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > _arrayOfT.Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return _arrayOfT[index];
            }

            set
            {
                if (index > _arrayOfT.Length - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _arrayOfT[index] = value;
            }
        }
    }
}
