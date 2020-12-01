using System;
using System.Collections.ObjectModel;
using task1EPAM.Contracts;
using task1EPAM.Model;
using task1EPAM.Service;

namespace task1EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }
        private static void StartMenu()
        {
            SaladCompilation complitation = new SaladCompilation();
            while (true)
            {
                Console.WriteLine("Choose operation with salad: \n" +
                    "1 - add vegetable to salad\n" +
                    "2 - calculate total calories in salad\n" +
                    "3 - find vegetables at calories range\n" +
                    "4 - sort calories by the one parameter\n" +
                    "5 - view salad ingridients");
                short operationNumber = Convert.ToInt16(Console.ReadLine());
                switch (operationNumber)
                {
                    case 1:
                        {

                            complitation.AddVegetable();
                            break;
                        }
                    case 2:
                        {
                            complitation.Calculate();
                            break;
                        }
                    case 3:
                        {
                            complitation.Search();
                            break;
                        }
                    case 4:
                        {
                            complitation.Sort();
                            break;
                        }
                    case 5:
                        {
                            if (complitation.Salad.SaladIngredients.Count != 0)
                            {
                                foreach (var ingredient in complitation.Salad.SaladIngredients)
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
    }
    
}
