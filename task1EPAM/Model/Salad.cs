using System.Collections.Generic;

namespace task1EPAM.Model
{
    internal class Salad
    {
        public IList<Vegetable> Ingredients { get; set; } = new List<Vegetable>();

        public double TotalCalories { get; set; }
    }
}
