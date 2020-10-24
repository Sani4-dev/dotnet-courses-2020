using System;

namespace Task3
{
    public class Comparator
    {
        public static bool StringOneGreaterThenStringTwo(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return String.Compare(str1, str2) >= 0;
            }

            return str1.Length > str2.Length;
        }
    }
}
