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
        private const string filePath = @"D:\Курсы .Net\task1\task1EPAM\task1EPAM\Data\Vegetables.json";
        public static void Deserialization()
        {  
            var jsonString = File.ReadAllText(filePath);
            ObservableCollection<Vegetable> vegetableCollection = null;
            vegetableCollection = JsonConvert.DeserializeObject<ObservableCollection<Vegetable>>(jsonString, new JsonSerializerSettings { });
        }
        //public static void Save(ObservableCollection<Vegetable> vegetableCollection)
        //{
        //    var resultString = JsonConvert.SerializeObject(vegetableCollection);
        //    using var filename = new FileStream(filePath, FileMode.Open);
        //    using var writer = new StreamWriter(filename, Encoding.Default);
        //    writer.Write(resultString);
        //    writer.Close();
        //}
    }
}
