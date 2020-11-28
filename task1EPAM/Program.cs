using System;
using System.Collections.ObjectModel;
using task1EPAM.Model;
using task1EPAM.Service;

namespace task1EPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetable vegetable = new Carrot("",3);
            ObservableCollection<Vegetable> collection = null ;
            JsonManager.Deserialization();

            //collection.Add(new Carrot("Carrot", 32));
            //collection.Add(new Onion("Onion", 41));
            //collection.Add(new Cucumber("Cucumber", 15));
            //collection.Add(new Tomato("Tomato", 18));
            //JsonManager.Save(collection);
        }
    }
    
}
