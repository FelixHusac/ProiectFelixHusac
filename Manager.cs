using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class Manager : Handler
    {
        public override void ProcessDiscount(Discount discount, PlaneTicket ticket)
        {
            if (discount.GetDiscount() < 0.5)
            {
                Console.WriteLine($"{this.GetType().Name} a aprobat discountul cu valaorea {discount.GetDiscount()}");
                discount.ApplyDiscountToTicket(ticket);
            }
            else if (HigherUp != null)
            {
                HigherUp.ProcessDiscount(discount, ticket);
            }
        }
    }
}
