using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            z1();//1)Из пяти введенных целых положительных чисел найти два наибольших и вывести сумму этих двух наибольших чисел.
            z2();//2)В вещественном массиве известны данные о количестве осадков,
                 //выпавших за каждый день месяца N (N - любой месяц в году).
                 //Найти общее число осадков, выпавших по четным числам месяца.
                 //Предоставить возможность пользователю реализовать заполнение массива случайными (рандомными) числами.
            z3();//3)Вводится строка. Длина строки может быть разной.Подсчитать и
                 //вывести количество содержащихся в ней прописных букв латинского алфавита.
            z4();//4)Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной.
                 //Найти и вывести все слова, которые начинающиеся только на цифру 3 или 7.

        }
        static void z1()
        {
            Console.WriteLine("Задание №1.\n");
            {
                int[] numbers = new int[5];
                Console.WriteLine("Введите 5 положительных целых чисел:");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Число {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                int max1 = numbers[0];
                int max2 = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max1)
                    {
                        max2 = max1;
                        max1 = numbers[i];
                    }
                    else if (numbers[i] > max2 && numbers[i] != max1)
                    {
                        max2 = numbers[i];
                    }
                }
                Console.WriteLine($"Два наибольших числа: {max1} и {max2}");
                Console.WriteLine($"Сумма двух наибольших чисел: {max1 + max2}");
            }
        }
        static void z2()
        {
            Console.WriteLine("Задание №2.\n");
            {
                Console.Write("Введите номер месяца (1-12): ");
                int month = Convert.ToInt32(Console.ReadLine());

                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Недопустимый месяц. Пожалуйста, введите значение от 1 до 12.");
                    return;
                }

                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
                double[] precipitation = new double[daysInMonth];
                Random rand = new Random();

                for (int i = 0; i < daysInMonth; i++)
                {
                    precipitation[i] = rand.NextDouble() * 100;
                }

                double totalEvenDaysPrecipitation = 0;

                for (int i = 1; i < daysInMonth; i += 2)
                {
                    totalEvenDaysPrecipitation += precipitation[i];
                }

                Console.WriteLine($"Общее количество осадков по четным дням месяца {month}: {totalEvenDaysPrecipitation:F2} мм");
            }
        }
        static void z3()
        {
            Console.WriteLine("Задание №3.\n");
            {
                Console.WriteLine("Введите строку:");
                string input = Console.ReadLine();

                int uppercaseCount = 0;
                foreach (char c in input)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        uppercaseCount++;
                    }
                }
                Console.WriteLine("Количество прописных букв латинского алфавита: " + uppercaseCount);
            }
        }
        static void z4()
        {
            Console.WriteLine("Задание №4.\n");
            {
                Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями:");
                string input = Console.ReadLine();

                string[] words = input.Split('_', (char)StringSplitOptions.RemoveEmptyEntries);
                List<string> resultWords = new List<string>();

                foreach (string word in words)
                {
                    if (word.StartsWith("3") || word.StartsWith("7"))
                    {
                        resultWords.Add(word);
                    }
                }

                if (resultWords.Count > 0)
                {
                    Console.WriteLine("Слова, которые начинаются на 3 или 7:");
                    foreach (string word in resultWords)
                    {
                        Console.WriteLine(word);
                    }
                }
                else
                {
                    Console.WriteLine("Слова, начинающиеся на 3 или 7, не найдены.");
                }
            }
        }
    }
}
