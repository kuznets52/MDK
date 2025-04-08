using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    public class task2
    {
        public double Power(double A, int N)
        {
            if (N <= 0)
            {
                throw new ArgumentException("N должно быть больше 0.");
            }
            double result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= A;
            }
            return result;
        }
    }
}