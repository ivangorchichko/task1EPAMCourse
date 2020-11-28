using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Contracts
{
    interface ISorting<Type>
    {
        void Sort(ObservableCollection<Vegetable> collection, Type param);
    }
}
