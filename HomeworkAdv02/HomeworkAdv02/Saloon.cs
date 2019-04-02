using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv02
{
    public class Saloon
    {
        // Car Saloon Class - specific parameter and method;

        public string SaloonName { get; set; }
        public string SaloonAddress { get; set; }
        public List<Car> ListOfCars { get; set; }

        public void BudgetPrice(int min, int max)
        {
            foreach (var cars in ListOfCars)
            {
                if ((cars.Price >= min) && (cars.Price <= max))
                {
                    Console.WriteLine(cars.GetCarInfo());
                }
            }
        }
    }
}
