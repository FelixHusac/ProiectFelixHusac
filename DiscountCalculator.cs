using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    class DiscountCalculator
    {
        public double Calculate(int age, int flights, double ammount) => (((age / 10) * ammount) + (flights / 10));
    }
}
