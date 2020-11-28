using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Contracts
{
    interface ICalculateable
    {
        double Calculate(ObservableCollection<Vegetable> collection);
    }
}
