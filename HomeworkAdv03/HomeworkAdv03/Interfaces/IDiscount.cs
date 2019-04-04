using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAdv03.Interfaces
{
    // Discount Interface - Discount Methods;

    public interface IDiscont
    {
        void SetDiscount(double discount);
        double GetPriceWithDiscount();
    }

}
