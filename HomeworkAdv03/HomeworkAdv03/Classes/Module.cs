using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAdv03.Interfaces;

namespace HomeworkAdv03.Classes
{
    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>();

        // Module Constructor;
        public Module()
        {

        }

        public Module(string name)
        {
            Name = name;
        }

        // Add parts Method;
        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        // Method calculation of the total Price and Quantity 
        // of all selected parts in the Module;
        public double GetPrice()
        {
            double total = 0;
            foreach (var price in _parts)
            {
                total += price.GetPrice();
            }

            return total;

        }

        // Method for Discount calculation;
        public void SetDiscount(double discount)
        {
            Discount = discount / 100;
        }

        // Method for total Price with Discount calculation;
        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }

    }
}
