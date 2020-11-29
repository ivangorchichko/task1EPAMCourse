using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM
{
    abstract class Vegetable
    {
        private double gram = 0;
        public string Name { get; private set; }
        public double Calories { get; private set; }
        public double Gram
        {
            get
            {
                return gram;
            }
            set
            {
                gram = value;
                Calories = Calories*gram/100;
            }
        }
        public Vegetable(string name, double calories, double gram)
        {
            Name = name;
            Calories = calories;
            Gram = gram;
        }
        public abstract void ShowVegetableInfo();
    }
}
