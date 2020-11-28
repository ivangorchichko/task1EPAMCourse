using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task1EPAM.Contracts
{
    interface ISearch
    {
        string Search(ObservableCollection<Vegetable> collection, double firstRange, double secondRange);
    }
}
