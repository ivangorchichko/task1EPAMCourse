using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM.Model
{
    abstract class Vegetable 
    {
        private double _gram;
        public string Name { get; private set; }
        public double Calories { get; private set; }
        public double Gram
        {
            get
            {
                return _gram;
            }
            set
            {
                _gram = value;
                Calories = Calories*_gram/100;
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
