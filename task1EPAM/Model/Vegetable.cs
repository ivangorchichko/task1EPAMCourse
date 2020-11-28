using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM
{
    abstract class Vegetable
    {
        public string Name { get; }
        public double Calories { get; }
        public double Gram { get; }
        public Vegetable(string name, double calories)
        {
            Name = name;
            Calories = calories;
        }
        public abstract void ShowVegetableInfo();
    }
}
