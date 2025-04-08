using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie2();
            zadanie1();
            zadanie3();
            zadanie4();
        }
        static void zadanie1()
        {
            try
            {
                Console.WriteLine("Введите пятизначное положительное число:");
                int number;

                while (!int.TryParse(Console.ReadLine(), out number) || number < 10000 || number > 99999)
                {
                    Console.WriteLine("Ошибка: введите корректное пятизначное положительное число.");
                }

                task15 task = new task15();
                bool result = task.AreDigitsUnique(number);

                if (result)
                {
                    Console.WriteLine("Все цифры данного пятизначного числа различны.");
                }
                else
                {
                    Console.WriteLine("Некоторые цифры данного пятизначного числа совпадают.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
        static void zadanie2()
        {
            try
            {
                Console.WriteLine("Введите вещественное число A:");
                double A;

                while (!double.TryParse(Console.ReadLine(), out A))
                {
                    Console.WriteLine("Ошибка: введите корректное вещественное число.");
                }

                Console.WriteLine("Введите целое число N (N > 0):");
                int N;

                while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                {
                    Console.WriteLine("Ошибка: введите корректное целое число больше 0.");
                }

                task2 task = new task2();
                double result = task.Power(A, N);

                Console.WriteLine($"Результат {A} в степени {N} равен {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
        static void zadanie3()
        {
            try
            {
                Console.WriteLine("Введите пять целых чисел:");

                int A = ReadInteger("A: ");
                int B = ReadInteger("B: ");
                int C = ReadInteger("C: ");
                int D = ReadInteger("D: ");
                int E = ReadInteger("E: ");

                task3 task = new task3();
                int result = task.Min2Of5Mul(A, B, C, D, E);

                Console.WriteLine($"Произведение двух минимальных чисел: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка формата: убедитесь, что вы вводите только целые числа.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ошибка переполнения: введенное число слишком велико или слишком мало.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
        private static int ReadInteger(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number; 
                }
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
        }
        static void zadanie4()
        {
            task4 task = new task4();

            try
            {
                Console.Write("Введите значение A: ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите значение B: ");
                int B = Convert.ToInt32(Console.ReadLine());

                int result = task.SumOfSquares(A, B);
                Console.WriteLine($"Сумма квадратов целых чисел от {A} до {B} равна: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком велико или слишком мало.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}