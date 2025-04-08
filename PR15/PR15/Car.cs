using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    class Car
    {
        public string Brand { get; private set; }
        public int CylinderCount { get; private set; }
        public double Power { get; private set; }

        public Car(string brand, int cylinderCount, double power)
        {
            Brand = brand;
            CylinderCount = cylinderCount;
            Power = power;
        }

        public void ChangePower(double newPower)
        {
            if (newPower < 0)
            {
                Console.WriteLine("Ошибка: Мощность должна быть положительной.");
                return;
            }
            Power = newPower;
            Console.WriteLine($"Мощность изменена на: {Power} л.с.");
        }

        public void ChangeBrand(string newBrand)
        {
            Brand = newBrand;
            Console.WriteLine($"Марка изменена на: {Brand}");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Brand}, Цилиндры: {CylinderCount}, Мощность: {Power} л.с.");
        }
    }
}