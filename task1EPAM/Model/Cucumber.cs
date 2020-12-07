using System;

namespace task1EPAM.Model
{
    internal sealed class Cucumber : Vegetable
    {
        public Cucumber(string name, double calories, double gram)
            :base (name,calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var cucumber = (Cucumber)vegetable;
            return new Cucumber(cucumber.Name, cucumber.Calories, cucumber.Gram);
        }
    }
}
