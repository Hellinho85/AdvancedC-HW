using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    public class Audi : Car
    {
        // Audi Class - Color specific parameter;

        public string Color { get; set; }

        public Audi(string model, Type type, Manufacturer manufacturer, int doorNum, string fuelType, double fuelCons, double price, string color)
            : base(model, type, manufacturer, doorNum, fuelType, fuelCons, price)
        {
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
            DoorNum = doorNum;
            FuelType = fuelType;
            FuelCons = fuelCons;
            Price = price;
            Color = color;
        }

        // Car Class - override method;

        public override string GetCarInfo()
        {
            return base.GetCarInfo() +
                $" Color: {Color}.";
        }

    }
}
