using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    class RangeSumCalculator
    {
        public int SumRange(int A, int B)
        {
            if (A <= 0 || B <= 0)
            {
                throw new ArgumentOutOfRangeException("A и B должны быть положительными целыми числами.");
            }

            if (A > B)
            {
                return 0;
            }

            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}