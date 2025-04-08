using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    public class task15
    {
        public bool AreDigitsUnique(int number)
        {
            if (number < 10000 || number > 99999)
            {
                throw new ArgumentException("Число должно быть пятизначным.");
            }

            string numberString = number.ToString();
            bool[] digitSeen = new bool[10];

            foreach (char digit in numberString)
            {
                int digitValue = digit - '0';
                if (digitSeen[digitValue])
                {
                    return false;
                }
                digitSeen[digitValue] = true;
            }

            return true;
        }
    }
}