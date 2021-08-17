using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
 public abstract class ToppingDecorator:IProduct
    {
        protected AProduct product;

        public ToppingDecorator(AProduct d)
        {
            product = d;
        }

        public abstract void addDiscount_price();
    }
}
