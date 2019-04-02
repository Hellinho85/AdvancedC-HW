using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    public class BMW : Car
    {
        // BMW Class - SunRoof specific parameter

        public bool SunRoof { get; set; }

        public BMW(string model, Type type, Manufacturer manufacturer, int doorNum, string fuelType, double fuelCons, double price, bool sunRoof)
            : base(model, type, manufacturer, doorNum, fuelType, fuelCons, price)
        {
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
            DoorNum = doorNum;
            FuelType = fuelType;
            FuelCons = fuelCons;
            Price = price;
            SunRoof = sunRoof;
        }

        // Car Class - override method;

        public override string GetCarInfo()
        {
            return base.GetCarInfo() +
                $" Sunroof: {SunRoof}.";
        }
    }
}
    

