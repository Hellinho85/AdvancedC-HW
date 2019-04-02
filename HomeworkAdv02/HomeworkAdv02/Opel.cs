using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    public class Opel : Car
    {
        // Opel Class - Country of origin specific parameter;

        public string Country { get; set; }

        public Opel(string model, Type type, Manufacturer manufacturer, int doorNum, string fuelType, double fuelCons, double price, string country)
            : base(model, type, manufacturer, doorNum, fuelType, fuelCons, price)
        {
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
            DoorNum = doorNum;
            FuelType = fuelType;
            FuelCons = fuelCons;
            Price = price;
            Country = country;
        }

        // Car Class - override method;

        public override string GetCarInfo()
        {
            return base.GetCarInfo() +
                $" Country: {Country}.";
        }
    }
}
