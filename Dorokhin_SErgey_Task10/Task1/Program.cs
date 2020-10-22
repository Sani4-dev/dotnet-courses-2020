using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
    
    class Program
    {
        public delegate bool ComparatorTwoString(string srt1, string str2);
        
        static void Main(string[] args)
        {
            string[] arrayOfString = new string[]{"different", "more", "linked", "apple", "pinapple", "sea", "automative", "sun",
                "foreground"};

            ComparatorTwoString comparatorTwoString = Comparator.StringOneGreaterThenStringTwo;

            for (int i = 0; i < arrayOfString.Length; i++)
            {
                for (int j = i; j < arrayOfString.Length; j++)
                {
                    if (comparatorTwoString.Invoke(arrayOfString[i], arrayOfString[j]))
                    {
                        string temp = arrayOfString[j];
                        arrayOfString[j] = arrayOfString[i];
                        arrayOfString[i] = temp;
                    }
                }
            }

            foreach (var item in arrayOfString)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
