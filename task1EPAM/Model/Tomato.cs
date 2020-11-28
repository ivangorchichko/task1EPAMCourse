using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM.Model
{
    sealed class Tomato : Vegetable
    {
        public Tomato(string name, double calories)
           : base(name, calories)
        {

        }

        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} : calories {Calories}, total grams {Gram}");
        }
    }
}
