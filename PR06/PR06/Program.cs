using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Vod:
            try
            {
                Console.WriteLine("Задание №1: Проверьте, является ли число нечетным трехзначным.");

                Console.WriteLine("Введите целое положительное трехзначное число:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 100 && number <= 999)
                {
                    if (number % 2 != 0)
                    {
                        Console.WriteLine("Данное число является нечетным трехзначным числом.");
                    }
                    else
                    {
                        Console.WriteLine("Данное число является четным трехзначным числом.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите трехзначное, целое, положительное число.");
                    goto Vod;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка формата: " + ex.Message);
                goto Vod;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Число слишком большое или слишком маленькое: " + ex.Message);
                goto Vod;
            }
            //задание 2
            {
                Console.WriteLine("Заданий №2 Введите четырехзначное положительное число (N > 0):");
                try
                {
                    int numbers = Convert.ToInt32(Console.ReadLine());

                    if (numbers < 1000 || numbers > 9999)
                    {
                        Console.WriteLine("Ошибка: Введите четырехзначное целое положительное число.");
                        return;
                    }

                    int sum = 0;
                    int product = 1;
                    bool hasEven = false;

                    while (numbers > 0)
                    {
                        int digit = numbers % 10;
                        sum += digit;

                        if (digit % 2 == 0)
                        {
                            product *= digit;
                            hasEven = true;
                        }

                        numbers /= 10;
                    }

                    if (!hasEven)
                    {
                        product = 0;
                    }

                    int difference = sum - product;
                    Console.WriteLine($"Разница между суммой всех цифр и произведением четных цифр: {difference}");
                }
                catch (System.FormatException ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
                catch (System.OverflowException ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
            }
            //задание №3
            Console.WriteLine("\nЗадание 3\n");

        Wod:
            try
            {

                int[] arr = { 2, 4, 6, 8, 10 };
                int n = arr.Length;

                if (n > 1)
                {
                    int firstElement = arr[0];
                    for (int i = 1; i < n - 1; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            arr[i] += firstElement;
                        }
                    }
                }

                Console.WriteLine("Преобразованный массив:");
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
            }
            catch (System.FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto Wod;
            }
            catch (System.OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto Wod;
            }
            //задание 4
            Console.WriteLine("\nЗадание 4\n");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int punctuationCount = 0;

            foreach (char c in input)
            {
                if (c == '.' || c == ',' || c == ':' || c == ';' || c == '!' || c == '?')
                {
                    punctuationCount++;
                }
            }
            Console.WriteLine("Количество знаков препинания: " + punctuationCount);

        }
    }
}