using System.Collections.Generic;
using task1EPAM.Enums;
using task1EPAM.Model;

namespace task1EPAM.Contracts
{
    internal interface ISaladService
    {
        void AddVegetable(Vegetable selectedVegetable);

        double CalculateCalories();

        void SearchByCalories(double minCalories, double maxCalories);

        void Sort(SortType sortType);

        IList<Vegetable> GetSaladComponents();
    }
}
