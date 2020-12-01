using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;
using task1EPAM.Model;

namespace task1EPAM.Service
{
    class JsonManager
    {
        private const string FilePath = @"D:\Курсы .Net\task1\task1EPAM\task1EPAM\Data\Vegetables.json";
        public static ObservableCollection<Vegetable> Deserialize()
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
            var jsonString = File.ReadAllText(FilePath);
            ObservableCollection<Vegetable> vegetableCollection = JsonConvert.DeserializeObject<ObservableCollection<Vegetable>>(jsonString, settings);
            return vegetableCollection;
        }





        //public static void Save(ObservableCollection<Vegetable> vegetableCollection)
        //{
        //    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
        //    var jsonString = JsonConvert.SerializeObject(vegetableCollection, settings);
        //    using var filename = new FileStream(filePath, FileMode.Open);
        //    using var writer = new StreamWriter(filename, Encoding.Default);
        //    writer.Write(jsonString);
        //    writer.Close();
        //}
    }
}
