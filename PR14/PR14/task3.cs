using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    public class task3
    {
        public int Min2Of5Mul(int A, int B, int C, int D, int E)
        {
            int[] numbers = { A, B, C, D, E };
            Array.Sort(numbers);

            return numbers[0] * numbers[1];
        }
    }
}