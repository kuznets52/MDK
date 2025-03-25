using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR13;

namespace PR13
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
                NumberFinder numberFinder = new NumberFinder();
                numberFinder.InputNumbers();
                int minimum = numberFinder.FindMinimum();
                Console.WriteLine($"Самое наименьшее число: {minimum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        static void zadanie2()
        {
            try
            {
                ArrayHandler arrayHandler = new ArrayHandler();
                arrayHandler.InputArray();
                int max = arrayHandler.FindMaximum();
                int min = arrayHandler.FindMinimum();
                int sum = max + min;

                Console.WriteLine($"Максимальный элемент: {max}");
                Console.WriteLine($"Минимальный элемент: {min}");
                Console.WriteLine($"Сумма максимального и минимального элемента: {sum}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
            }
        }
        static void zadanie3()
        {
            try
            {
                TimeConverter timeConverter = new TimeConverter();
                Console.WriteLine("Введите часы:");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите минуты:");
                int minutes = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите секунды:");
                int seconds = int.Parse(Console.ReadLine());

                int totalSeconds = timeConverter.TimeToSec(hours, minutes, seconds);
                Console.WriteLine($"Общее количество секунд: {totalSeconds}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
            }
        }
        static void zadanie4()
        {
            try
            {
                Console.WriteLine("Введите A (положительное целое число):");
                int A = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите B (положительное целое число):");
                int B = int.Parse(Console.ReadLine());

                RangeSumCalculator calculator = new RangeSumCalculator();
                int sum = calculator.SumRange(A, B);
                Console.WriteLine($"Сумма чисел от {A} до {B} включительно: {sum}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка ввода: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
            }
        }
    }
}