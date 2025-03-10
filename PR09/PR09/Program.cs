using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
//2. В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N (N - любой месяц в году).
//Верно ли, что по четным числам выпало больше осадков, чем по нечетным? Предоставить возможность пользователю реализовать заполнение массива случайными (рандомными) числами.
//3. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной.
//Определить и вывести количество слов, которые содержат ровно одну букву 'w'.
//4. Написать функцию int Max3Of5Sum(A, B, C, D, E) целого типа, возвращающую сумму трех самых максимальных значений из 5-ти своих аргументов (параметры A, B, C, D и E - целые числа).
//5. Написать функцию int Min4(A, B, C, D) целого типа, возвращающую одно минимальное значение из 4-х своих аргументов (параметры A, B, C и D - целые числа).
namespace PR09
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
            try
            {

                Console.WriteLine("Введите число A:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число C:");
                int C = Convert.ToInt32(Console.ReadLine());

                bool isAPositive = A > 0;
                bool isBPositive = B > 0;
                bool isCPositive = C > 0;

                bool exactlyOnePositive = (isAPositive ? 1 : 0) + (isBPositive ? 1 : 0) + (isCPositive ? 1 : 0) == 1;

                if (exactlyOnePositive)
                {
                    Console.WriteLine("Ровно одно из чисел A, B, C положительное.");
                }
                else
                {
                    Console.WriteLine("Не одно из чисел A, B, C положительное или их больше одного.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите целые числа.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком велико или слишком мало. Пожалуйста, введите целое число в допустимом диапазоне.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
        static void zadanie2()
        {
            Random random = new Random();

            Console.WriteLine("Введите количество дней в месяце (1-31):");
            int days = 0;

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    days = int.Parse(input);

                    if (days < 1 || days > 31)
                    {
                        throw new ArgumentOutOfRangeException("Количество дней должно быть от 1 до 31.");
                    }
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }

            double[] precipitation = new double[days];

            for (int i = 0; i < days; i++)
            {
                precipitation[i] = Math.Round(random.NextDouble() * 100, 2);
                Console.WriteLine($"День {i + 1}: {precipitation[i]} мм");
            }

            double evenSum = 0;
            double oddSum = 0;

            for (int i = 0; i < days; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    evenSum += precipitation[i];
                }
                else
                {
                    oddSum += precipitation[i];
                }
            }

            Console.WriteLine($"\nОбщее количество осадков в четные дни: {evenSum} мм");
            Console.WriteLine($"Общее количество осадков в нечетные дни: {oddSum} мм");

            if (evenSum > oddSum)
            {
                Console.WriteLine("В четные дни выпало больше осадков, чем в нечетные.");
            }
            else if (evenSum < oddSum)
            {
                Console.WriteLine("В нечетные дни выпало больше осадков, чем в четные.");
            }
            else
            {
                Console.WriteLine("Количество осадков в четные и нечетные дни одинаковое.");
            }
        }
        static void zadanie3()
        {
            Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями:");

            string input = string.Empty;

            try
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentException("Строка не должна быть пустой.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
                return;
            }

            string[] words = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (var word in words)
            {
                int wCount = 0;

                foreach (char c in word)
                {
                    if (c == 'w' || c == 'W')
                    {
                        wCount++;
                    }
                }

                if (wCount == 1)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество слов, содержащих ровно одну букву 'w': {count}");
        }
        static void zadanie4()
        {
            try
            {
                Console.WriteLine("Введите пять целых чисел, разделенных пробелами:");

                string[] input = Console.ReadLine().Split(' ');
                if (input.Length != 5)
                {
                    throw new ArgumentException("Необходимо ввести ровно пять целых чисел.");
                }

                int[] numbers = Array.ConvertAll(input, int.Parse);

                int result = Max3Of5Sum(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                Console.WriteLine($"Сумма трех максимальных значений: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен содержать только целые числа.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static int Max3Of5Sum(int A, int B, int C, int D, int E)
        {
            int[] numbers = { A, B, C, D, E };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            return numbers[0] + numbers[1] + numbers[2];
        }
    }
}