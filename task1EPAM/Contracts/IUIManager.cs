using System;
using System.Collections.Generic;
using task1EPAM.Model;

namespace task1EPAM.Contracts
{
    internal interface IUIManager
    {
        void ShowOperationsMenu();

        bool TryParseEnum<T>(out T operation) where T : struct, IConvertible;

        void ShowAvailableVegetables();

        Vegetable SelectVegetable();

        int GetVegetableGram();

        void DisplaySaladComponents(IList<Vegetable> components);

        void ShowAvaibleParameters();

        double GetMinCaloriesRange();

        double GetMaxCaloriesRange();

        void ShowSaladTotalCalories();
    }
}
