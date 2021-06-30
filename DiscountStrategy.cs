using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public interface IDiscountStrategy
    {
        public double CalculateDiscount(PlaneTicket ticket);
    }
}
