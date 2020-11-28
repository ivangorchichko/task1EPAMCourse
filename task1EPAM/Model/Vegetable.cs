using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM
{
    abstract class Vegetable
    {
        public string Name { get; }
        public double Calories { get; }
        public double Gramm { get; }
        public Vegetable(string name, double calories, double gramm)
        {
            Name = name;
            Calories = calories;
            Gramm = gramm;
        }
        protected abstract void ShowVegetableInfo();
    }
}
