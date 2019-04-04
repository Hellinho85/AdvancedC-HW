using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAdv03.Interfaces;

namespace HomeworkAdv03.Classes
{

    // Class Extension - Method for Price with Currency;

    public static class ExtensionCurrency
    {
        public static string PriceWithCurrency(this double value, string currency)
        {
            return $"{value} {currency}";
        }

    }
}
