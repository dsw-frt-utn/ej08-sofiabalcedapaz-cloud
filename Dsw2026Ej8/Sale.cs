using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        protected decimal amount;

        public Sale(decimal amount)
        {
            this.amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return amount;
        }
    }
}
