using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lesson
{
    class Task1
    {
        public string Convert10to2(int num, string intString)
        {
            if (num < 2)
            {
                int t = num % 2;
                intString = intString + t.ToString();              
                string newIntString = "";
                for (int i = intString.Length - 1; i >= 0; i--)
                    newIntString = newIntString + intString[i];
                return newIntString;
            }
            else
            {
                int t = num % 2;
                intString = intString + t.ToString();
                return Convert10to2(num / 2, intString);
            }
        }
    }
}
