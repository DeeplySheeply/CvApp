using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.LocalHelperMethods.StringBuilderLocal
{
    public class StringBManipulation
    {
        // Reverse a string builder object
        public static StringBuilder ReverseStringB(StringBuilder strB)
        {
            StringBuilder reversedStringB = new StringBuilder();

            for (int i = strB.Length - 1; i > -1; i--)
            {
                reversedStringB.Append(strB[i]);
            }
            return reversedStringB;
        }
    }
}
