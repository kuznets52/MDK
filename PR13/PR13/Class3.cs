using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    class TimeConverter
    {
        public int TimeToSec(int hours, int minutes, int seconds)
        {
            if (hours < 0 || minutes < 0 || seconds < 0)
            {
                throw new ArgumentOutOfRangeException("Часы, минуты и секунды не могут быть отрицательными.");
            }

            if (minutes >= 60)
            {
                throw new ArgumentOutOfRangeException("Минуты должны быть меньше 60.");
            }

            if (seconds >= 60)
            {
                throw new ArgumentOutOfRangeException("Секунды должны быть меньше 60.");
            }

            return (hours * 3600) + (minutes * 60) + seconds;
        }
    }
}