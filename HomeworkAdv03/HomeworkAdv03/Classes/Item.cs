using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAdv03.Interfaces;

namespace HomeworkAdv03.Classes
{
    // Abstract Class - PC Items, Parts and GetPrice Method 
    // for muliplying the Price with the Quantity of Parts;

    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } = 1;
        public double Discount { get; set; }
    }

    public class Part : Item, IPrice
    {
        // Method for total Price and Quantity calculation;
        public double GetPrice()
        {
            return Price * Quantity;
        }

    }
}
