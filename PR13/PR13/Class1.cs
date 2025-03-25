using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    class NumberFinder
    {
        private int[] numbers;

        public NumberFinder()
        {
            numbers = new int[5];
        }

        public void InputNumbers()
        {
            Console.WriteLine("Введите 5 различных ненулевых положительных и отрицательных чисел:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Число {i + 1}: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out numbers[i]) || numbers[i] == 0)
                {
                    throw new Exception("Введено неверное число. Пожалуйста, введите целое ненулевое число.");
                }

                if (Array.IndexOf(numbers, numbers[i], 0, i) != -1)
                {
                    throw new Exception("Числа должны быть различными. Попробуйте снова.");
                }
            }
        }

        public int FindMinimum()
        {
            int minimum = numbers[0];

            foreach (int number in numbers)
            {
                if (number < minimum)
                {
                    minimum = number;
                }
            }

            return minimum;
        }
    }
}
