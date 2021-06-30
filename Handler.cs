using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public abstract class Handler
    {
        protected Handler HigherUp;

        public void SetHigherUp(Handler higherUp)
        {
            HigherUp = higherUp;
        }

        public abstract void ProcessDiscount(Discount discount, PlaneTicket ticket);
    }
}
