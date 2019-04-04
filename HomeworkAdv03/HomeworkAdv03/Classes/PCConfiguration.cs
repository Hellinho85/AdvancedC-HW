using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAdv03.Interfaces;
using static HomeworkAdv03.Enums.Colors;

namespace HomeworkAdv03.Classes
{
    public class PCConfiguration : Item, IPrice, IDiscont
    {
        // Configuration properties        
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; }
        public Enums.Colors BoxColor { get; set; }

        // Configuration Constructor
        public PCConfiguration()
        {

        }

        // Enum implementation;
        public PCConfiguration(Enums.Colors boxColor)
        {
            BoxColor = boxColor;
        }

        // Add Part to Configuration Method;
        public void AddPartToProduct(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);

        }

        // Add Module to Configuration Method;
        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            module.Quantity = quantity;
            _modules.Add(module);
        }

        // Method calculation of the total Price and Quantity 
        // of all selected Parts and Modules in the Configuration; 
        public double GetPrice()
        {
            double partTotal = 0;
            double moduleTotal = 0;
            foreach (var part in _parts)
            {
                partTotal += part.GetPrice();
            }

            foreach (var module in _modules)
            {
                moduleTotal += module.GetPrice();
            }

            return partTotal + moduleTotal;

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

