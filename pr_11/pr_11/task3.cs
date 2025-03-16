using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_11
{
    class ArrayHandler
    {
        public int[] GetArrayFromUser()
        {
            try
            {
                Console.Write("Введите количество элементов в массиве (N > 0): ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Ошибка: Введите корректное положительное целое число.");
                }

                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = GetNumberFromUser($"Введите элемент {i + 1}: ");
                }

                return array;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при получении массива", ex);
            }
        }

        private int GetNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите корректное целое число.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }
        }
    }

    class ArrayProcessor
    {
        public int[] AddMaxEvenToOdds(int[] numbers)
        {
            try
            {
                int maxEven = numbers.Where(x => x % 2 == 0).DefaultIfEmpty(int.MinValue).Max();

                int[] resultArray = numbers.Select(x => (x % 2 != 0) ? x + maxEven : x).ToArray();

                return resultArray;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при обработке массива", ex);
            }
        }
    }
}