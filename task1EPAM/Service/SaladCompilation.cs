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
