using System;

namespace task1EPAM.Model
{
    internal sealed class Cucumber : Vegetable
    {
        private const string _acidity = "5,5 - 7,0";
        public Cucumber(string name, double calories, double gram)
            :base (name,calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams, acidity = {_acidity}");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var cucumber = (Cucumber)vegetable;
            return new Cucumber(cucumber.Name, cucumber.Calories, cucumber.Gram);
        }
    }
}
