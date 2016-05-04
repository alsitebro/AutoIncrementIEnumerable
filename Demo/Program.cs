using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Helpers;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * List<T> implements the IEnumerable interface, so it would also implement
             * the extension method created in the Helpers namespace
             **/
            List<Item> listOfItems = new List<Item>();
            Console.WriteLine("Generating data...");
            GenerateCollection(listOfItems);
            Console.WriteLine("Press [ENTER] to display data...");
            Console.ReadLine();
            DisplaysCollectionItems(listOfItems);
            Console.ReadLine();
        }

        private static void GenerateCollection(List<Item> items)
        {
            for (int i = 0; i < 10; i++)
            {
                items.Add(new Item { Content = string.Format("Content {0}", i), Id = items.AutoIncrement() });
            }
        }

        private static void DisplaysCollectionItems(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine("ID: {0} Content: {1} Index: {2}", item.Id, item.Content, items.IndexOf(item));
            }
        }
    }
}
