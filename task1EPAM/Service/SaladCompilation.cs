using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using task1EPAM.Contracts;
using task1EPAM.Model;

namespace task1EPAM.Service
{
    class SaladCompilation : ISearch, ICalculateable, ISorting, IAdd
    {
        public Salad Salad { get; set; }
        public ObservableCollection<Vegetable> VegetablesCollection { get; set; }
        public SaladCompilation()
        {
            VegetablesCollection = VegetableCollection.GetCollection(JsonManager.Deserialize());
            Salad = new Salad();
        }
        public void AddVegetable()
        {
            var number = 0;
            foreach (var vegetable in VegetablesCollection)
            {
                Console.Write(++number + " - ");
                vegetable.ShowVegetableInfo();
            }
            Console.WriteLine("Choose vegetable:");
            short vegetableNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Choose gram of vegetable:");
            short vegetableGram = Convert.ToInt16(Console.ReadLine());
            //ObservableCollection<Vegetable> ingridient
            //    = new ObservableCollection<Vegetable>() { VegetablesCollection[vegetableNumber - 1] };
            var selectedVegetable = VegetablesCollection[vegetableNumber - 1];
            //Vegetable vegetable1 = VegetableCollection[vegetableNumber - 1];
            selectedVegetable.Gram = vegetableGram;
            
            Salad.SaladIngredients.Add(selectedVegetable);
        }
        public void Calculate()
        {
            foreach (var ingredient in Salad.SaladIngredients)
            {
                Salad.TotalCalories += ingredient.Calories;
            }
            Console.WriteLine($"Total calories: {Salad.TotalCalories}");
        }

        public void Search()
        {
            Console.WriteLine("Input fisrt range:");
            short firstCaloriesRange = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input second range:");
            short secondCaloriesRange = Convert.ToInt16(Console.ReadLine());
            foreach(var ingredients in Salad.SaladIngredients)
            {
                if(ingredients.Calories <= secondCaloriesRange && ingredients.Calories >= firstCaloriesRange)
                {
                    ingredients.ShowVegetableInfo();
                }
            }
        }

        public void Sort()
        {
            Console.WriteLine("Choose parameter to sort: \n" +
                    "1 - Name\n" +
                    "2 - Calories\n" +
                    "3 - Gram\n");
            short parameterNumber = Convert.ToInt16(Console.ReadLine());
            switch(parameterNumber)
            {
                case 1:
                    {
                        Salad.SaladIngredients
                            = new ObservableCollection<Vegetable>(Salad.SaladIngredients.OrderBy(x => x.Name).ToList());
                        break;
                    }
                case 2:
                    {
                        Salad.SaladIngredients
                            = new ObservableCollection<Vegetable>(Salad.SaladIngredients.OrderBy(x => x.Calories).ToList());
                        break;
                    }
                case 3:
                    {
                        Salad.SaladIngredients
                            = new ObservableCollection<Vegetable>(Salad.SaladIngredients.OrderBy(x => x.Gram).ToList());
                        break;
                    }
            }
        }

        




        //private void StartMenu()
        //{
        //    while(true)
        //    {
        //        Console.WriteLine("Choose operation with salad: \n" +
        //            "1 - add vegetable to salad\n" +
        //            "2 - calculate total calories in salad\n" +
        //            "3 - find vegetables at calories range\n" +
        //            "4 - sort calories by the one parameter\n" +
        //            "5 - view salad ingridients");
        //        short operationNumber = Convert.ToInt16(Console.ReadLine());
        //        switch(operationNumber)
        //        {
        //            case 1:
        //                {
        //                    foreach(var vegetable in vegetablesCollection)
        //                    {
        //                        vegetable.ShowVegetableInfo();
        //                    }
        //                    Console.WriteLine("Choose vegetable:");
        //                    short vegetableNumber = Convert.ToInt16(Console.ReadLine());
        //                    Console.WriteLine("Choose gram of vegetable:");
        //                    short vegetableGram = Convert.ToInt16(Console.ReadLine());
        //                    vegetablesCollection[vegetableNumber].Gram = vegetableGram;
        //                    salad.SaladIngredients.Add(vegetablesCollection[vegetableNumber]);
        //                    break;
        //                }
        //            case 2:
        //                {
        //                    foreach(var ingredient in salad.SaladIngredients)
        //                    {
        //                        salad.TotalCalories += ingredient.Calories;
        //                    }
        //                    Console.WriteLine($"Total calories: {salad.TotalCalories}");
        //                    break;
        //                }
        //            case 5:
        //                {
        //                    if (salad.SaladIngredients.Count != 0)
        //                    {
        //                        foreach (var ingredient in salad.SaladIngredients)
        //                        {
        //                            ingredient.ShowVegetableInfo();
        //                        }
        //                    }
        //                    else Console.WriteLine("Nothing added!");
        //                    break;
        //                }
        //        }
        //    }
        //}

    }
}
