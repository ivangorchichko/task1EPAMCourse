using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM.Model
{
    sealed class Tomato : Vegetable
    {
        public Tomato(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }

        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} : calories {Calories}, total grams {Gram}");
        }
    }
}
