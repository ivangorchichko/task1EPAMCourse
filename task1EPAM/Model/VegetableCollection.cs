﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Model
{
    class VegetableCollection
    {
        private static ObservableCollection<Vegetable> _vegetableCollection;
        private VegetableCollection(ObservableCollection<Vegetable> collection)
        {
            _vegetableCollection = collection;
        }
        public static ObservableCollection<Vegetable> GetCollection(ObservableCollection<Vegetable> collection)
        {
            if (_vegetableCollection == null)
            {
                _vegetableCollection = new ObservableCollection<Vegetable>(collection);
            }
            return _vegetableCollection;
        }
    }
}
