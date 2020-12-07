using task1EPAM.Contracts;
using task1EPAM.Enums;
using task1EPAM.Service;

namespace task1EPAM
{
    class Program
    {
        private static readonly IVegetablesRepository _vegetablesRepository = new JsonVegetablesRepository();
        private static readonly ISaladService _saladService = new SaladService(_vegetablesRepository);
        private static readonly IUIManager _uIManager = new ConsoleManager(_saladService, _vegetablesRepository);

        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            while (true)
            {
                _uIManager.ShowOperationsMenu();
                if (!_uIManager.TryParseEnum<Operation>(out var operation))
                {
                    continue;
                }else 
                if(operation == 0)
                {
                    break;
                }
                switch (operation)
                {
                    case Operation.Add:
                        {
                            _uIManager.ShowAvailableVegetables();
                            var selectedVegetable = _uIManager.SelectVegetable();
                            var selectedVegetableGram = _uIManager.GetVegetableGram();
                            selectedVegetable.Gram = selectedVegetableGram;
                            _saladService.AddVegetable(selectedVegetable);
                            break;
                        }
                    case Operation.Calculate:
                        {
                            _uIManager.ShowSaladTotalCalories();
                            break;
                        }
                    case Operation.Search:
                        {
                            var minCalories = _uIManager.GetMinCaloriesRange();
                            var maxCalories = _uIManager.GetMaxCaloriesRange();
                            _saladService.SearchByCalories(minCalories, maxCalories);
                            break;
                        }
                    case Operation.Sort:
                        {
                            _uIManager.ShowAvaibleParameters();
                            if (!_uIManager.TryParseEnum<SortType>(out var sortType))
                            {
                                continue;
                            }
                            _saladService.Sort(sortType);
                            break;
                        }
                    case Operation.View:
                        {
                            _uIManager.DisplaySaladComponents(_saladService.GetSaladComponents());
                            break;
                        }
                }
            }
        }
    }
}
