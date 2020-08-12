using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Lesson
{
    class Task2
    {
        public double PowRec(double a, int b)
        {
            if (b == 0) return 1;
            else if (b % 2 == 1) return a * PowRec(a, b - 1);
            else return PowRec(a * a, b / 2);
        }

        public double PowIter(double a, int b)
        {
            double result = 1;
            for (int i =1;i<=b;i++)
            {
                result *= a;
            }
            return result;
        }
    }
}

