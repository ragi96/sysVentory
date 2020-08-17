using System;
using Datasource;

namespace TestApp {
    static class Program {
        static void Main(string[] args) {
            // synchrone Variante
            //var data = Data.Read();
            //Callback(data);

            // asynchrone Variante
            Data.ReadAsync(Callback);

            Console.ReadKey();
        }

        private static void Callback(Data data) {
            foreach (var item in data) {
                Console.WriteLine(item.ItemType);
                foreach (var prop in item.Properties) {
                    Console.WriteLine($"       {prop.Name}: {prop.Value}");
                }
            }
        }
    }
}
