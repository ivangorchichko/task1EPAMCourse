using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Model
{
    class Salad
    {
        public ObservableCollection<Vegetable> SaladIngredients { get; set; }
        public double TotalCalories { get; set; }
        public Salad()
        {
            SaladIngredients = new ObservableCollection<Vegetable>();
        }
    }
}
