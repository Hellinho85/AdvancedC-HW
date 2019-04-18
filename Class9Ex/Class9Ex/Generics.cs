using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{
    public class Generics
    {
        // Generic Method that prints all items from a list;
        public void PrintList<T>(List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // Generic Method that prints any list of Animals items from a list;
        public void PrintAnimals<T>(List<T> animals) where T : Animal
        {
            foreach (var animal in animals)
            {
                animal.PrintAll();
            }
        }

    }
}
