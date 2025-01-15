using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 15\n\n");

            V08();
            V12();
            V15();
        }

        static void V08()
        {
            Console.WriteLine("Вычисление стоимости покупки некоторого количества яблок (по весу)");
            Console.WriteLine("Цена одного килограмма яблок (руб.):");
            int G = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вес яблок (кг):");
            double Y = Convert.ToDouble(Console.ReadLine());
            double T = G*Y;
            Console.WriteLine("Стоимость покупки = {0} руб.", T);
        }

        static void V12()
        {
            Console.WriteLine("\nЗадание 12. Вычисление сопротивления электрической цепи, состоящей из двух последовательно соединенных сопротивлений");
            Console.WriteLine("Величина первого сопротивления (Ом):");
            double F = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Величина второго сопротивления (Ом):");
            double J = Convert.ToDouble(Console.ReadLine());
            double K = F + J;
            Console.WriteLine("Сопротивление цепи (последовательное соединение) = {0} (Ом)", K);
        }

        static void V15()
        {
            Console.WriteLine("\n Задание 15. Вычисление стоимости поездки на автомобиле на дачу (туда и обратно).");
            Console.WriteLine("Расстояние до дачи (км):");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расход бензина (литров на 100 км пробега):");
            double U = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена литра бензина (руб.):");
            double R = Convert.ToDouble(Console.ReadLine());
            double Z = 2*K*(U/100)*R;
            Console.WriteLine("Поездка на дачу и обратно обойдется в {0} руб.", Z);
        }
    }
}