using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Contracts
{
    interface ISorting
    {
        void Sort(ObservableCollection<Vegetable> collection, string param);
    }
}
