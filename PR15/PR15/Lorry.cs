using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    class Lorry : Car
    {
        public double LoadCapacity { get; private set; }
        public Lorry(string brand, int cylinderCount, double power, double loadCapacity)
            : base(brand, cylinderCount, power)
        {
            LoadCapacity = loadCapacity;
        }

        public void ChangeLoadCapacity(double newLoadCapacity)
        {
            if (newLoadCapacity < 0)
            {
                Console.WriteLine("Ошибка: Грузоподъемность должна быть положительной.");
                return;
            }
            LoadCapacity = newLoadCapacity;
            Console.WriteLine($"Грузоподъемность изменена на: {LoadCapacity} кг");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Грузоподъемность: {LoadCapacity} кг");
        }
    }
}