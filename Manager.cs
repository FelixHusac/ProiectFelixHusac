using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class Manager : Handler
    {
        public override void ProcessDiscount(Discount d, PlaneTicket t)
        {
            if (d.GetDiscount() < 0.5)
            {
                Console.WriteLine("{0} a aprobat discountul cu valaorea {1}", this.GetType().Name, d.GetDiscount());
                d.ApplyDiscountToTicket(t);
            }
            else if (higherUp != null)
            {
                higherUp.ProcessDiscount(d, t);
            }
        }
    }
}
