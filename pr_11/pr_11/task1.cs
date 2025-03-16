using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_11
{

    class NumberInputHandler
    {
        public (int A, int B, int C) GetNumbersFromUser()
        {
            int A = GetNumberFromUser("Введите число A: ");
            int B = GetNumberFromUser("Введите число B: ");
            int C = GetNumberFromUser("Введите число C: ");

            return (A, B, C);
        }

        private int GetNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите корректное целое число.");
                }
            }

            return number;
        }
    }

    class PositiveNumberChecker
    {
        public bool IsExactlyOnePositive(int A, int B, int C)
        {
            int positiveCount = 0;

            if (A > 0) positiveCount++;
            if (B > 0) positiveCount++;
            if (C > 0) positiveCount++;

            return positiveCount == 1;
        }
    }
}