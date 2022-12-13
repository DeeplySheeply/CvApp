using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LocalHelperMethods.StringsLocal
{
    public class StringManipulation
    {
        // Method for reversing a string
        public static string ReverseString(string str)
        {
            StringBuilder reversedString = new StringBuilder();

            for (int i = str.Length - 1; i > -1; i--)
            {
                reversedString.Append(str[i]);
            }
            str = reversedString.ToString();
            return str;
        }

        // This method removes all characters from a string that are non-alphabetic
        public static void RemoveNonAlphabetic(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'A' || str[i] > 'Z' &&
                        str[i] < 'a' || str[i] > 'z')
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }
        }

    }
}
