using System;
using System.Collections.Generic;
using System.Text;

namespace task1EPAM.Model
{
    sealed class Cucumber : Vegetable
    {
        public Cucumber(string name, double calories)
            :base (name,calories)
        {

        }
        public override void ShowVegetableInfo()
        {
            throw new NotImplementedException();
        }
    }
}
