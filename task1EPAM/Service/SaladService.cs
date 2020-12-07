using System.Collections.Generic;
using System.Linq;
using task1EPAM.Contracts;
using task1EPAM.Enums;
using task1EPAM.Model;

namespace task1EPAM.Service
{
    class SaladService : ISaladService
    {
        private IVegetablesRepository _vegetablesRepository;
        private Salad _salad;

        public SaladService(IVegetablesRepository vegetablesRepository)
        {
            _vegetablesRepository = vegetablesRepository;
            _salad = new Salad();
        }
        public IEnumerable<Vegetable> GetAvailableVegetable()
        {
            return _vegetablesRepository.GetAvailableVegetable(); 
        }
        public void AddVegetable(Vegetable selectedVegetable)
        {            
            _salad.Ingredients.Add(selectedVegetable);
        }
        public double CalculateCalories()
        {
            _salad.TotalCalories = _salad.Ingredients.Sum(x => x.Calories);
            return _salad.TotalCalories;
        }
        public void SearchByCalories(double minCalories, double maxCalories)
        {
            foreach(var ingredients in _salad.Ingredients)
            {
                if(ingredients.Calories <= maxCalories && ingredients.Calories >= minCalories)
                {
                    ingredients.ShowVegetableInfo();
                }
            }
        }
        public void Sort(SortType sortType)
        {
            switch (sortType)
            {
                case SortType.Name:
                    {
                        _salad.Ingredients
                            = _salad.Ingredients.OrderBy(x => x.Name).ToList();
                        break;
                    }
                case SortType.Calories:
                    {
                        _salad.Ingredients
                            = _salad.Ingredients.OrderBy(x => x.Calories).ToList();
                        break;
                    }
                case SortType.Gram:
                    {
                        _salad.Ingredients
                            = _salad.Ingredients.OrderBy(x => x.Gram).ToList();
                        break;
                    }
            }
        }
        public IList<Vegetable> GetSaladComponents()
        {
            return _salad.Ingredients;
        }
    }
}
