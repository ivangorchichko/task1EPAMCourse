using System;

namespace task1EPAM.Model
{
    public abstract class Vegetable : ICloneable
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
                Calories = Calories * _gram / 100;
            }
        }

        public Vegetable(string name, double calories, double gram)
        {
            Name = name;
            Calories = calories;
            Gram = gram;
        }

        public virtual void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} : calories {Calories}, total grams {Gram}");
        }

        public object Clone() => CreateClone(this);

        protected abstract Vegetable CreateClone(Vegetable vegetable);
    }
}
