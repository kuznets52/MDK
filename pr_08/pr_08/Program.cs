using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = -2;
            int C = 1;

            bool hasOneRealRoot = Funkciu1(A, B, C);

            if (hasOneRealRoot)
            {
                Console.WriteLine("Квадратное уравнение имеет ровно один вещественный корень.");
            }
            else
            {
                Console.WriteLine("Квадратное уравнение не имеет ровно одного вещественного корня.");
            }
        }

        //задани2
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6 };

            int result = CheckAlternatingEvenOdd(array);

            if (result == 0)
            {
                Console.WriteLine("Чередование четных и нечетных чисел соблюдено.");
            }
            else
            {
                Console.WriteLine($"Нарушение чередования на позиции {result} (элемент {array[result]}).");
            }
        }
        //задание3
        static void Main(string[] args)
        {

            Console.Write("Введите положительное целое число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int decimalNumber) && decimalNumber > 0)
            {
                string binaryRepresentation = Convert.ToString(decimalNumber, 2);
                Console.WriteLine($"Двоичная запись числа {decimalNumber}: {binaryRepresentation}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное положительное целое число.");
            }
        }
        //задание 4
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите положительное целое число K: ");
                int K = int.Parse(Console.ReadLine());

                Console.Write("Введите номер N: ");
                int N = int.Parse(Console.ReadLine());

                int result = DigitN(K, N);
                if (result == -1)
                {
                    Console.WriteLine($"В числе {K} меньше {N} цифр.");
                }
                else
                {
                    Console.WriteLine($"N-я цифра числа {K} (считая справа налево): {result}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен быть целым положительным числом.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком велико или слишком мало.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }

        static int DigitN(int K, int N)
        {

            if (K <= 0 || N <= 0)
            {
                return -1; 
            }

            int currentDigit;

            for (int i = 1; i <= N; i++)
            {
                currentDigit = K % 10; 
                K /= 10;

                if (i == N)
                {
                    return currentDigit;
                }
            }

            return -1;
        }
    }
}   
  