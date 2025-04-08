using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    public class task4
    {
        public int SumOfSquares(int A, int B)
        {
            if (A > B)
            {
                return 0;
            }

            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i * i;
            }
            return sum;
        }
    }
}