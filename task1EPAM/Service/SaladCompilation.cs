using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using task1EPAM.Contracts;
using task1EPAM.Model;

namespace task1EPAM.Service
{
    class SaladCompilation : ISearch, ICalculateable, ISorting
    {
        private Salad salad;
        private ObservableCollection<Vegetable> vegetablesCollection;
        public SaladCompilation()
        {
            vegetablesCollection = VegetableCollection.GetCollection(JsonManager.Deserialization());
            salad = new Salad();
            StartMenu();
        }

        private void StartMenu()
        {
            while(true)
            {
                Console.WriteLine("Choose operation with salad: \n" +
                    "1 - add vegetable to salad\n" +
                    "2 - calculate total calories in salad\n" +
                    "3 - find vegetables at calories range\n" +
                    "4 - sort calories by the one parameter\n" +
                    "5 - view salad ingridients");
                short operationNumber = Convert.ToInt16(Console.ReadLine());
                switch(operationNumber)
                {
                    case 1:
                        {
                            foreach(var vegetable in vegetablesCollection)
                            {
                                vegetable.ShowVegetableInfo();
                            }
                            Console.WriteLine("Choose vegetable:");
                            short vegetableNumber = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Choose gram of vegetable:");
                            short vegetableGram = Convert.ToInt16(Console.ReadLine());
                            vegetablesCollection[vegetableNumber].Gram = vegetableGram;
                            salad.SaladIngredients.Add(vegetablesCollection[vegetableNumber]);
                            break;
                        }
                    case 2:
                        {
                            foreach(var ingredient in salad.SaladIngredients)
                            {
                                salad.TotalCalories += ingredient.Calories;
                            }
                            Console.WriteLine($"Total calories: {salad.TotalCalories}");
                            break;
                        }
                    case 5:
                        {
                            if (salad.SaladIngredients.Count != 0)
                            {
                                foreach (var ingredient in salad.SaladIngredients)
                                {
                                    ingredient.ShowVegetableInfo();
                                }
                            }
                            else Console.WriteLine("Nothing added!");
                            break;
                        }
                }
            }
        }
        public double Calculate(ObservableCollection<Vegetable> collection)
        {
            throw new NotImplementedException();
        }

        public string Search(ObservableCollection<Vegetable> collection, double firstRange, double secondRange)
        {
            throw new NotImplementedException();
        }

        public void Sort(ObservableCollection<Vegetable> collection,string param)
        {
            throw new NotImplementedException();
        }
    }
}
