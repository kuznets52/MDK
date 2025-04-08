using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            zadanie2();
        }
        static void zadanie1()
        {
            try
            {

                Console.Write("Введите марку машины: ");
                string brand = Console.ReadLine();

                Console.Write("Введите количество цилиндров (положительное число): ");
                int cylinderCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите мощность (положительное число): ");
                double power = Convert.ToDouble(Console.ReadLine());

                Car myCar = new Car(brand, cylinderCount, power);
                myCar.DisplayInfo();

                Console.Write("Введите новую мощность (положительное число): ");
                double newPower = Convert.ToDouble(Console.ReadLine());
                myCar.ChangePower(newPower);

                Console.Write("Введите грузоподъемность (положительное число): ");
                double loadCapacity = Convert.ToDouble(Console.ReadLine());

                Lorry myLorry = new Lorry(brand, cylinderCount, power, loadCapacity);
                myLorry.DisplayInfo();

                Console.Write("Введите новую грузоподъемность (положительное число): ");
                double newLoadCapacity = Convert.ToDouble(Console.ReadLine());
                myLorry.ChangeLoadCapacity(newLoadCapacity);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректные данные.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком велико или слишком мало.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
        static void zadanie2()
        {
            try
            {
                Console.Write("Введите название жидкости: ");
                string name = Console.ReadLine();

                Console.Write("Введите плотность (положительное число): ");
                double density = Convert.ToDouble(Console.ReadLine());
                if (density <= 0)
                {
                    throw new ArgumentException("Плотность должна быть положительной.");
                }
                Liquid myLiquid = new Liquid(name, density);
                myLiquid.DisplayInfo();
                Console.Write("Введите новую плотность (положительное число): ");
                double newDensity = Convert.ToDouble(Console.ReadLine());
                myLiquid.ChangeDensity(newDensity);
                Console.Write("Введите крепость спирта (0-100): ");
                double strength = Convert.ToDouble(Console.ReadLine());
                if (strength < 0 || strength > 100)
                {
                    throw new ArgumentException("Крепость должна быть в диапазоне от 0 до 100.");
                }
                Alcohol myAlcohol = new Alcohol(name, density, strength);
                myAlcohol.DisplayInfo();

                Console.Write("Введите новую крепость спирта (0-100): ");
                double newStrength = Convert.ToDouble(Console.ReadLine());
                myAlcohol.ChangeStrength(newStrength);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректные данные.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком велико или слишком мало.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}