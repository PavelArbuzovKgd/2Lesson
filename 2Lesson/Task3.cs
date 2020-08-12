using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lesson
{
    class Task3
    {
        int c = 0;
        
        public int CalcRec(int a, int b)
        {           
            for (int i = 0; i < 2; i++)
            {                
                int n = a;
                if (i == 0)
                {
                    n++;
                }
                else
                {
                    n *= 2;
                }
                if (n < b) CalcRec(n, b);
                else
                    if (n == b) c++;
            }
            return c;
        }
    }
}
