using System;

namespace task1EPAM.Model
{
    internal sealed class Carrot : Vegetable
    {
        private const string _kind = "Vitaminous";
        public Carrot(string name, double calories, double gram)
           : base(name, calories, gram)
        {

        }
        public override void ShowVegetableInfo()
        {
            Console.WriteLine($"{Name} has {Calories} calories in {Gram} grams, kind of {_kind}");
        }
        protected override Vegetable CreateClone(Vegetable vegetable)
        {
            var carrot = (Carrot)vegetable;
            return new Carrot(carrot.Name, carrot.Calories, carrot.Gram);
        }
    }
}
