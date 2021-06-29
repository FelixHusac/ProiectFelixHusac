using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeictHusacFelix
{
    public abstract class Handler
    {
        protected Handler higherUp;

        public void SetHigherUp(Handler higherUp)
        {
            this.higherUp = higherUp;
        }

        public abstract void ProcessDiscount(Discount d, PlaneTicket t);
    }
}
