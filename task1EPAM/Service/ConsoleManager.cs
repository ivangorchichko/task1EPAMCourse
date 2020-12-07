using System;
using task1EPAM.Contracts;
using task1EPAM.Model;
using System.Linq;
using System.Collections.Generic;

namespace task1EPAM.Service
{
    class ConsoleManager : IUIManager
    {
        private readonly ISaladService _saladService;
        private readonly IVegetablesRepository _vegetablesRepository;

        public ConsoleManager(ISaladService saladService, IVegetablesRepository vegetablesRepository)
        {
            _saladService = saladService;
            _vegetablesRepository = vegetablesRepository;
        }
        public Vegetable SelectVegetable()
        {
            Console.WriteLine("Choose needed vegetable");
            var vegetableNumber = Convert.ToInt16(Console.ReadLine());
            return (Vegetable)_vegetablesRepository.GetAvailableVegetable().ToArray()[vegetableNumber - 1].Clone();
        }
        public void ShowOperationsMenu()
        {
            Console.WriteLine("Choose operation with salad: \n" +
                  "1 - add vegetable to salad\n" +
                  "2 - calculate total calories in salad\n" +
                  "3 - find vegetables at calories range\n" +
                  "4 - sort calories by the one parameter\n" +
                  "5 - view salad ingridients\n" +
                  "0 - stop program");
        }
        public bool TryParseEnum<T>(out T operation) where T : struct, IConvertible
        {
            var operationNumber = Console.ReadLine();
            var isParseCorrected = Enum.TryParse(operationNumber, out operation);
            if(isParseCorrected)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Не удалось считать номер операции");
                return false;
            }

        }
        public int GetVegetableGram()
        {
            Console.WriteLine("Choose vegetable gram");
            var vegetableGram = Convert.ToInt32(Console.ReadLine());
            return vegetableGram;
        }
        public void ShowAvailableVegetables()
        {
            var number = 0;
            foreach(var vegetable in _vegetablesRepository.GetAvailableVegetable())
            {
                Console.Write(++number + " - ");
                vegetable.ShowVegetableInfo();
            }
        }
        public void DisplaySaladComponents(IList<Vegetable> components)
        {
            if (components.Count != 0)
            {
                foreach (var ingredient in components)
                { 
                    ingredient.ShowVegetableInfo();
                }
            }
            else Console.WriteLine("Nothing added!");
        }
        public void ShowAvaibleParameters()
        {
            Console.WriteLine("Choose parameter to sort: \n" +
                                    "1 - Name\n" +
                                    "2 - Calories\n" +
                                    "3 - Gram\n");
        }
        public double GetMinCaloriesRange()
        {
            Console.WriteLine("Input min calories range:");
            double minCalories = Convert.ToInt16(Console.ReadLine());
            return minCalories;
        }
        public double GetMaxCaloriesRange()
        {
            Console.WriteLine("Input max calories range:");
            double maxCalories = Convert.ToInt16(Console.ReadLine());
            return maxCalories;
        }
        public void ShowSaladTotalCalories()
        {
            Console.WriteLine("Total calories : " + _saladService.CalculateCalories());
        }
    }
}
