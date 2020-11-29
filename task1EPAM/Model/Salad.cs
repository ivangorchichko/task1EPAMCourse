using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM.Model
{
    class Salad
    {
        public List<Vegetable> SaladIngredients { get; set; }
        public double TotalCalories { get; set; }
        public Salad()
        {
            SaladIngredients = new List<Vegetable>();
            TotalCalories = 0;
        }
    }
}
