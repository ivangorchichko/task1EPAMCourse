using System;

namespace task1EPAM.Model
{
    internal sealed class Onion : Vegetable
    {
        private const string _sugarContent = "8 - 14 %";
        public Onion(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams, sugar content = {_sugarContent}");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var onion = (Onion)vegetable;
            return new Onion(onion.Name, onion.Calories, onion.Gram);
        }
    }
}
