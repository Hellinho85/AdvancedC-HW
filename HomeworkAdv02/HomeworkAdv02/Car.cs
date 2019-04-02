using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    public abstract class Car
    {
        // Car Class - Parameters;

        public string Model { get; set; }
        public Type Type { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int DoorNum { get; set; }
        public string FuelType { get; set; }
        public double FuelCons { get; set; }
        public double Price { get; set; }

        // Car Class Constructor

        public Car()
        {

        }

        public Car(string model, Type type, Manufacturer manufacturer, int doorNum, string fuelType, double fuelCons, double price)
        {
            Model = model;
            Type = type;
            Manufacturer = manufacturer;
            DoorNum = doorNum;
            FuelType = fuelType;
            FuelCons = fuelCons;
            Price = price;
        }

        // Car Class - virtual method;
        public virtual string GetCarInfo()
        {
            return $"Model {Model};" +
                $" Type: {Type};" +
                $" Manufacturer: {Manufacturer};" +
                $" Door Numbers: {DoorNum};" +
                $" Fuel Type: {FuelType}," +
                $" Fuel Consumption: {FuelCons}," +
                $" Price: {Price}";
        }
    }
}
