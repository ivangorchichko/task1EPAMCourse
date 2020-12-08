using System;

namespace task1EPAM.Model
{
    internal sealed class Tomato : Vegetable
    {
        private const string _organicAcid = "3,5 - 8,5 %";
        public Tomato(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams, organic acidity = {_organicAcid}");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var tomato = (Tomato)vegetable;
            return new Tomato(tomato.Name, tomato.Calories, tomato.Gram);
        }
    }
}
