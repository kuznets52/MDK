using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    class ArrayHandler
    {
        private int[] _numbers;

        public void InputArray()
        {
            Console.WriteLine("Введите количество элементов массива (N > 0):");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("Количество элементов должно быть больше 0.");
            }

            _numbers = new int[n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                _numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public int FindMaximum()
        {
            if (_numbers.Length == 0)
            {
                throw new InvalidOperationException("Массив пуст.");
            }

            int max = _numbers[0];
            foreach (var number in _numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        public int FindMinimum()
        {
            if (_numbers.Length == 0)
            {
                throw new InvalidOperationException("Массив пуст.");
            }

            int min = _numbers[0];
            foreach (var number in _numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}