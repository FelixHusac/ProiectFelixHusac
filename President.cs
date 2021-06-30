using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public class President : Handler
    {
        public override void ProcessDiscount(Discount discount, PlaneTicket ticket)
        {
            if (discount.GetDiscount() < 0.8)
            {
                Console.WriteLine($"{this.GetType().Name} a aprobat discountul cu valaorea {discount.GetDiscount()}");
                discount.ApplyDiscountToTicket(ticket);
            }
            else 
            {
                Console.WriteLine("Discountul oferit nu poate fi onorat!\n");
            }
        }
    }
}
