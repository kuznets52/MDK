

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PR08
//1.Проверить истинность высказывания: "Квадратное уравнение A·x2 + B·x + C = 0 с данными коэффициентами A (A не равно 0), B, C имеет ровно один вещественный корень".
//2.Дан целочисленный массив, состоящий из N элементов (N > 0). Проверить, чередуются ли в нем четные и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.
//3. Вводится строка, изображающая десятичную запись целого положительного числа. Вывести строку, изображающую двоичную запись этого же числа.
//4. Написать функцию int DigitN(K, N) целого типа, возвращающую N-ю цифру целого положительного числа K (цифры в числе нумеруются справа налево). Если количество цифр в числе K меньше N, то функция должна возвращать значение -1.
//5. Написать функцию int SumRange(A, B) целого типа, находящую сумму всех целых чисел в диапазоне от A до B включительно (A и B — целые положительные). Если A > B, то функция должна возвращать число 0.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        M:
            try
            {
                Console.WriteLine("Выберите задание (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                        M1:
                            try
                            {
                                int A = 0;
                                int B = 0;
                                int C = 0;
                                Console.WriteLine("Введите коэффициенты A, B и C: ");
                                A = Convert.ToInt32(Console.ReadLine());
                                B = Convert.ToInt32(Console.ReadLine());
                                C = Convert.ToInt32(Console.ReadLine());
                                bool Otvet = CheckRoots(A, B, C);
                                Console.WriteLine("Квадратное уравнение имеет ровно один вещественный корень: {0}", Otvet);
                                goto M;
                            }
                            catch (System.FormatException ex1)
                            {
                                Console.WriteLine("{0}", ex1.Message);
                                goto M1;
                            }
                            catch (System.OverflowException ex2)
                            {
                                Console.WriteLine("{0}", ex2.Message);
                                goto M1;
                            }
                        }

                    case 2:
                        {
                            CheckAlternatingEvenOdd();
                            goto M;
                        }

                    case 3:
                        {
                            ConvertDecimalToBinary();
                            goto M;
                        }

                    case 4:
                        {
                            GetNthDigit();
                            goto M;
                        }

                    case 5:
                        {
                            CalculateSumRange();
                            goto M;
                        }
                    default:
                        Console.WriteLine("Неверный выбор задания.");
                        goto M;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
                goto M;
            }
        }
        static void Pervoe()
        {
        M1:
            try
            {
                int A = 0;
                int B = 0;
                int C = 0;
                Console.WriteLine("Введите коэффициенты A, B и C: ");
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
                C = Convert.ToInt32(Console.ReadLine());
                bool Otvet = CheckRoots(A, B, C);
                Console.WriteLine("Квадратное уравнение имеет ровно один вещественный корень: {0}", Otvet);
                goto M1;
            }
            catch (System.FormatException ex1)
            {
                Console.WriteLine("{0}", ex1.Message);
                goto M1;
            }
            catch (System.OverflowException ex2)
            {
                Console.WriteLine("{0}", ex2.Message);
                goto M1;
            }
        }
        static void CheckAlternatingEvenOdd()
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Количество элементов должно быть больше 0.");
                return;
            }

            int[] array = new int[N];
            Console.WriteLine("Введите элементы массива: ");

            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < N; i++)
            {
                if ((array[i - 1] % 2 == 0 && array[i] % 2 == 0) ||
                    (array[i - 1] % 2 != 0 && array[i] % 2 != 0))
                {
                    Console.WriteLine("Первый элемент, нарушающий закономерность: {0}", i);
                    return;
                }
            }

            Console.WriteLine("Чередование четных и нечетных чисел соблюдено. Вывод: 0");
        }

        static void ConvertDecimalToBinary()
        {
            Console.WriteLine("Введите целое положительное число в десятичной записи: ");
            string input = Console.ReadLine();

            if (!ulong.TryParse(input, out ulong decimalNumber) || decimalNumber == 0)
            {
                Console.WriteLine("Ошибка: Введите положительное целое число.");
                return;
            }

            string binaryRepresentation = string.Empty;

            while (decimalNumber > 0)
            {
                binaryRepresentation = (decimalNumber % 2) + binaryRepresentation;
                decimalNumber /= 2;
            }

            Console.WriteLine("Двоичное представление числа равно {0}", binaryRepresentation);
        }

        static bool CheckRoots(int A, int B, int C)
        {
            if (A != 0)
            {
                double D = B * B - 4 * A * C;
                return D == 0;
            }
            return false;
        }
        static void GetNthDigit()
        {
            Console.WriteLine("Введите целое положительное число K: ");
            string inputK = Console.ReadLine();

            if (!ulong.TryParse(inputK, out ulong K))
            {
                Console.WriteLine("Ошибка: Введите положительное целое число.");
                return;
            }

            Console.WriteLine("Введите номер цифры N (считаем справа налево): ");
            if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
            {
                Console.WriteLine("Ошибка: Введите положительное целое число для N.");
                return;
            }

            int digit = DigitN(K, N);
            if (digit == -1)
            {
                Console.WriteLine("Количество цифр в числе K меньше N.");
            }
            else
            {
                Console.WriteLine("N-я цифра числа K: {0}", digit);
            }
        }

        static int DigitN(ulong K, int N)
        {
            string KString = K.ToString();

            if (KString.Length < N)
            {
                return -1;
            }

            char digitChar = KString[KString.Length - N];
            return (int)char.GetNumericValue(digitChar);
        }

        static void CalculateSumRange()
        {
            Console.WriteLine("Введите целое число A: ");
            if (!int.TryParse(Console.ReadLine(), out int A))
            {
                Console.WriteLine("Ошибка: Введите целое число для A.");
                return;
            }

            Console.WriteLine("Введите целое число B: ");
            if (!int.TryParse(Console.ReadLine(), out int B))
            {
                Console.WriteLine("Ошибка: Введите целое число для B.");
                return;
            }

            int sum = SumRange(A, B);
            Console.WriteLine("Сумма всех целых чисел в диапазоне от {0} до {1} равна {2}.", A, B, sum);
        }

        static int SumRange(int A, int B)
        {
            if (A > B)
            {
                return 0;
            }

            int sum = 0;

            for (int i = A; i <= B; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}