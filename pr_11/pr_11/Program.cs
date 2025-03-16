using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pr_11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            zadanie4();
            zadanie1();
            zadanie3();
        }
        static void zadanie4()
        {
            YearInputHandler inputHandler = new YearInputHandler();
            int year = inputHandler.GetYearFromUser();

            LeapYearChecker leapYearChecker = new LeapYearChecker();
            bool isLeapYear = leapYearChecker.IsLeapYear(year);

            Console.WriteLine($"Ответ: {isLeapYear}");
        }
        static void zadanie1()
        {

            NumberInputHandler inputHandler = new NumberInputHandler();
            (int A, int B, int C) = inputHandler.GetNumbersFromUser();

            PositiveNumberChecker positiveChecker = new PositiveNumberChecker();
            bool isExactlyOnePositive = positiveChecker.IsExactlyOnePositive(A, B, C);

            Console.WriteLine($"Ровно одно из чисел A, B, C положительное: {isExactlyOnePositive}");
        }
        static void zadanie3()
        {
            try
            {
                ArrayHandler arrayHandler = new ArrayHandler();
                int[] numbers = arrayHandler.GetArrayFromUser();

                ArrayProcessor arrayProcessor = new ArrayProcessor();
                int[] resultArray = arrayProcessor.AddMaxEvenToOdds(numbers);

                Console.WriteLine("Полученный массив:");
                Console.WriteLine(string.Join(", ", resultArray));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}