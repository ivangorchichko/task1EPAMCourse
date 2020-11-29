using System;
using System.Collections.Generic;
using System.Text;
using task1EPAM.Contracts;

namespace task1EPAM.Model
{
    sealed class Carrot : Vegetable
    {
        public Carrot(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} : calories {Calories}, total grams {Gram}");
        }
        
    }
}
