using System.Collections.Generic;
using task1EPAM.Model;

namespace task1EPAM.Contracts
{
    public interface IVegetablesRepository
    {
        IEnumerable<Vegetable> GetAvailableVegetable();
    }
}
