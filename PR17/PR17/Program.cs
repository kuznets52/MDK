using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PR17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            zadanie2();
            zadanie3();
            zadanie4();
        }
        static void zadanie1()
        {
            // задание1
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17/task01");
            try
            {
                Console.Write("Введите трехзначное положительное число: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 100 || number > 999)
                    throw new ArgumentOutOfRangeException("Число должно быть трехзначным.");
                int hundreds = number / 100;
                int tens = (number / 10) % 10;
                int units = number % 10;
                bool areDistinct = (hundreds != tens) && (hundreds != units) && (tens != units);

                key.SetValue("result1", areDistinct ? 1 : 0);
                Console.WriteLine($"Все цифры различны: {areDistinct}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное целое число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                key.Close();
            }

        }
        static void zadanie3()
        {
            // задание3
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17/task03");
            try
            {
                Console.Write("Введите количество элементов массива (N > 0): ");
                int N = int.Parse(Console.ReadLine());
                if (N <= 0) throw new ArgumentOutOfRangeException("N должно быть больше нуля.");
                int[] array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Введите элемент массива {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                int sum = 0;
                int product = 1;
                bool hasEvenNumbers = false;

                foreach (var num in array)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                        product *= num;
                        hasEvenNumbers = true;
                    }
                }
                if (!hasEvenNumbers) product = 0;
                key.SetValue("sumEven", sum);
                key.SetValue("productEven", product);

                Console.WriteLine($"Сумма четных чисел: {sum}, Произведение четных чисел: {product}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное целое число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                key.Close();
            }
        }
        static void zadanie2()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17/task02");
            try
            {
                int[] numbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Введите {i + 1}-е ненулевое целое число: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] == 0)
                        throw new ArgumentException("Число не должно быть нулем.");
                }

                var topThree = numbers.OrderByDescending(n => n).Take(3);
                int product = topThree.Aggregate(1, (current, number) => current * number);

                key.SetValue("result2", product);

                Console.WriteLine($"Произведение трех наибольших чисел: {product}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное целое число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                key.Close();
            }
        }
        static void zadanie4()
        {
            //задание4
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17/task04");
            try
            {
                Console.Write("Введите A (положительное целое число): ");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Введите B (положительное целое число): ");
                int B = int.Parse(Console.ReadLine());

                if (A <= 0 || B <= 0) throw new ArgumentOutOfRangeException("A и B должны быть положительными.");

                int result = MulRange(A, B);

                key.SetValue("result4", result);

                Console.WriteLine($"Произведение чисел от {A} до {B}: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное целое число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                key.Close();
            }
        }

        static int MulRange(int A, int B)
        {
            if (A > B) return 0;

            int product = 1;
            for (int i = A; i <= B; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}