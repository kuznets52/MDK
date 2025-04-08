using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15
{
    class Alcohol : Liquid
    {
        public double Strength { get; private set; }
        public Alcohol(string name, double density, double strength)
            : base(name, density)
        {
            Strength = strength;
        }

        public void ChangeStrength(double newStrength)
        {
            if (newStrength < 0 || newStrength > 100)
            {
                Console.WriteLine("Ошибка: Крепость должна быть в диапазоне от 0 до 100.");
                return;
            }
            Strength = newStrength;
            Console.WriteLine($"Крепость изменена на: {Strength}%");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Крепость: {Strength}%");
        }
    }
}