using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using task1EPAM.Model;
using task1EPAM.Contracts;

namespace task1EPAM.Service
{
    public class JsonVegetablesRepository : IVegetablesRepository
    {
        private const string _filePath = @"Data\Vegetables.json";

        public IEnumerable<Vegetable> GetAvailableVegetable()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
            var jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<IEnumerable<Vegetable>>(jsonString, settings);
        }
    }
}
