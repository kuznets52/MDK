using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А12/Б15"
                + "\n Задание 1. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».\"."
                + "\n Задание 2. Ввести пять различных ненулевых целых чисел. Найти произведение трех наибольших чисел."
                + "\n Задание 3. Проверить истинность высказывания: Все цифры данного целого положительного четырехзначного числа различны."
                + "\n Задание 4. Из пяти целых различных ненулевых положительных и отрицательных чисел найти самое наименьшее число.."
                + "\n Задание 5. Дан номер месяца N - целое положительное число в диапазоне от 1 до 12 (1 - январь, 2 - февраль, ..., 12 - декабрь). Вывести название соответствующего номера квартала (квартал – это четвертая часть года, один квартал = три месяца) («1 квартал», «2 квартал», ..., «4 квартал»).");

            Vopros01();
            Vopros02();
            Vopros03();
            Vopros04();
            Vopros05();
        }


        static void Vopros01()
        {
            Console.WriteLine("Задание 1.");

        Start: // Метка для возврата
            try
            {
                Console.WriteLine("Задайте целое число A:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте целое число B:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте целое число C:");
                int C = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nПроверка на истинность высказывания: «Каждое из чисел A, B, C положительное»\n");

                //Проверка на положительность чисел
                if (A > 0 && B > 0 && C > 0)
                {
                    Console.WriteLine("Высказывание истинно: все числа положительны.");
                }
                else
                {
                    Console.WriteLine("Высказывание ложно: не все числа положительны.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.\n");
                goto Start;
            }
        }

        static void Vopros02()
        {
            Console.WriteLine("Задание 2.");

        Start:
            try
            {
                Console.WriteLine("Задайте первое ненулевое целое число:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте второе ненулевое целое число:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте третье ненулевое целое число:");
                int C = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте четвёртое ненулевое целое число:");
                int D = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте пятое ненулевое целое число:");
                int E = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nВычисление произведения трёх наибольших чисел.\n");

                if (A == 0 || B == 0 || C == 0 || D == 0 || E == 0)
                {
                    Console.WriteLine("Ошибка: одно или несколько чисел равны нулю. Попробуйте снова.\n");
                    goto Start;
                }

                int[] numbers = { A, B, C, D, E };
                Array.Sort(numbers); //Сортировка массива чисел по возрастанию

                int max1 = numbers[4];
                int max2 = numbers[3];
                int max3 = numbers[2];

                int umnozhenie = max1 * max2 * max3;

                Console.WriteLine("Три наибольших числа: {0}, {1}, {2}", max1, max2, max3);
                Console.WriteLine("Их произведение: {0}", umnozhenie);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.\n");
                goto Start;
            }
        }

        static void Vopros03()
        {
            Console.WriteLine("Задание 3.\n");
        Start:
            try
            {
                Console.WriteLine("Введите целое положительное четырехзначное число:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 1000 || num > 9999)
                {
                    Console.WriteLine("\nОшибка: введите положительное четырехзначное число.\n");
                    goto Start;
                }

                string str = num.ToString();

                bool allDistinct = true;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            allDistinct = false;
                            break;
                        }
                    }
                    if (!allDistinct)
                    {
                        break;
                    }
                }
                 if (allDistinct)
                {
                    Console.WriteLine("\nПравда: Все цифры числа различны.");
                }
                else
                {
                    Console.WriteLine("\nЛожь: Есть повторяющиеся цифры в числе.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Vopros04()
        {
            Console.WriteLine("Задание 4.\n");
        Start:
            try
            {
                int[] numbers = new int[5]; //Массив для хранения 5 чисел

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Введите {i + 1}-е целое ненулевое число:");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 0)
                    {
                        Console.WriteLine("\nОшибка: число должно быть ненулевым.\n");
                        i--; //Уменьшаем счетчик, чтобы повторить ввод
                        continue;
                    }

                    if (Array.Exists(numbers, element => element == num))
                    {
                        Console.WriteLine("\nОшибка: число должно быть уникальным.\n");
                        i--; //Уменьшаем счетчик, чтобы повторить ввод
                        continue;
                    }

                    numbers[i] = num; //Сохраняем число в массив
                }

                int minNumber = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    minNumber = Math.Min(minNumber, numbers[i]);
                }

                Console.WriteLine("\nСамое наименьшее число из введенных: {0}", minNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Vopros05()
        {
        Console.WriteLine("Задание 5.\n");

        int N;

        while (true)
        {
            try
            {
                Console.WriteLine("Введите номер месяца (1-12):");
                N = Convert.ToInt32(Console.ReadLine());

                if (N < 1 || N > 12)
                {
                    Console.WriteLine("\nОшибка: номер месяца должен быть от 1 до 12.\n");
                    continue;
                }

                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное число.\n");
            }
        }

        int quarter;
        switch (N)
        {
            case 1:
            case 2:
            case 3:
                quarter = 1;
                break;
            case 4:
            case 5:
            case 6:
                quarter = 2;
                break;
            case 7:
            case 8:
            case 9:
                quarter = 3;
                break;
            case 10:
            case 11:
            case 12:
                quarter = 4;
                break;
            default:
                quarter = 0; 
                break;
        }

        Console.WriteLine($"\n{N}-й месяц соответствует {quarter} кварталу.");
        }
    }
}