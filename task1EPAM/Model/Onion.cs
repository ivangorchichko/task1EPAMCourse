using System;

namespace task1EPAM.Model
{
    internal sealed class Onion : Vegetable
    {
        public Onion(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var onion = (Onion)vegetable;
            return new Onion(onion.Name, onion.Calories, onion.Gram);
        }
    }
}
