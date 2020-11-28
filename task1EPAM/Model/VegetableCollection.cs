using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Model
{
    class VegetableCollection
    {
        private static ObservableCollection<Vegetable> _vegetableCollection;
        private VegetableCollection()
        {

        }
        public static ObservableCollection<Vegetable> GetCollection()
        {
            if (_vegetableCollection == null)
            {
                _vegetableCollection = new ObservableCollection<Vegetable>();
            }
            return _vegetableCollection;
        }
    }
}
