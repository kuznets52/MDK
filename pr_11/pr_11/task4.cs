using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_11
{
   
     class YearInputHandler
    {
        public int GetYearFromUser()
        {
            int year;

            while (true)
            {
                Console.Write("Введите год: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out year))
                {
                    if (year < 0)
                    {
                        Console.WriteLine("Введено некорректное значение!!!");
                        continue; 
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите корректное целое число.");
                }
            }

            return year;
        }
    }

   
    class LeapYearChecker
    {
        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}