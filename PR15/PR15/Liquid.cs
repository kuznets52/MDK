using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    class Liquid
    {
        public string Name { get; private set; }
        public double Density { get; private set; }

        public Liquid(string name, double density)
        {
            Name = name;
            Density = density;
        }
        public void ChangeDensity(double newDensity)
        {
            if (newDensity <= 0)
            {
                Console.WriteLine("Ошибка: Плотность должна быть положительной.");
                return;
            }
            Density = newDensity;
            Console.WriteLine($"Плотность изменена на: {Density} г/см³");
        }
        public void Rename(string newName)
        {
            Name = newName;
            Console.WriteLine($"Название изменено на: {Name}");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}, Плотность: {Density} г/см³");
        }
    }
}