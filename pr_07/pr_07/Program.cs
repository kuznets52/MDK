using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 2.\n");

                string[] inputs = File.ReadAllLines("input2.txt");
                int number = Convert.ToInt32(inputs[0]);

                bool isEvenThreeDigit = (number > 99 && number < 1000 && number % 2 == 0);

                using (StreamWriter writer = new StreamWriter("output2.txt"))
                {
                    if (isEvenThreeDigit)
                    {
                        writer.WriteLine("Данное целое положительное число является четным трехзначным числом.");
                    }
                    else
                    {
                        writer.WriteLine("Данное целое положительное число не является четным трехзначным числом.");
                    }
                }
                Console.WriteLine("Результат записан в файл: output2.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }

            Console.WriteLine("\nЗадание 2.\n");

            try
            {
                string[] inpup = File.ReadAllLines("input2.txt");
                int[] numbers = new int[inpup.Length];

                for (int i = 0; i < inpup.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(inpup[i]);
                }

                foreach (int number in numbers)
                {
                    if (number < 1000 || number > 9999)
                    {
                        throw new ArgumentException("Все числа должны быть четырехзначными и положительными.");
                    }

                    int sumOfDigits = 0;
                    int productOfOddDigits = 1;
                    bool hasOddDigit = false;

                    int tempNumber = number;
                    while (tempNumber > 0)
                    {
                        int digit = tempNumber % 10;
                        sumOfDigits += digit;

                        if (digit % 2 != 0)
                        {
                            productOfOddDigits *= digit;
                            hasOddDigit = true;
                        }

                        tempNumber /= 10;
                    }

                    if (!hasOddDigit)
                    {
                        productOfOddDigits = 0;
                    }

                    int difference = sumOfDigits - productOfOddDigits;

                    using (StreamWriter writer = new StreamWriter("output2.txt", true))
                    {
                        writer.WriteLine("Для числа {0}: Сумма цифр = {1}, Произведение нечетных цифр = {2}, Разница = {3}",
                            number, sumOfDigits, productOfOddDigits, difference);
                    }
                }

                Console.WriteLine("Результат записан в файл: output2.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
            Console.WriteLine("\nЗадание 3.\n");
            try
            {
                string[] inpt = File.ReadAllLines("input3.txt");
                int N = Convert.ToInt32(inpt[0]);
                string[] numbersString = inpt[1].Split(' ');
                int[] numbers = Array.ConvertAll(numbersString, int.Parse);

                if (numbers.Length != N)
                {
                    Console.WriteLine("Ошибка! Количество элементов в массиве не соответствует указанному N.");
                    return;
                }

                int maxOdd = int.MinValue;
                foreach (int number in numbers)
                {
                    if (number % 2 != 0 && number > maxOdd)
                    {
                        maxOdd = number;
                    }
                }

                if (maxOdd == int.MinValue)
                {
                    Console.WriteLine("Ошибка! В массиве нет нечетных чисел.");
                    return;
                }

                int[] resultArray = new int[N];

                for (int i = 0; i < N; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        resultArray[i] = numbers[i] + maxOdd;
                    }
                    else
                    {
                        resultArray[i] = numbers[i];
                    }
                }

                using (StreamWriter writer = new StreamWriter("output3.txt"))
                {
                    writer.WriteLine("Результирующий массив: {0}", string.Join(" ", resultArray));
                }

                Console.WriteLine("Результат записан в файл: output3.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }

            Console.WriteLine("\nЗадание 4.\n");

            string input = "input4.txt";
            string output = "output4.txt";

            try
            {

                string inputString = File.ReadAllText(input);

                int sumOfEvenDigits = 0;

                foreach (char c in inputString)
                {

                    if (char.IsDigit(c))
                    {
                        int digit = c - '0';

                        if (digit % 2 == 0)
                        {
                            sumOfEvenDigits += digit;
                        }
                    }
                }

                File.WriteAllText(output, sumOfEvenDigits.ToString());
                Console.WriteLine("Сумма четных цифр: {0}", sumOfEvenDigits);
                Console.WriteLine("Результат записан в файл {0}", output);
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
        }
    }
}
   