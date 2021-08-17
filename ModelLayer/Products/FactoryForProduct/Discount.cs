using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class Discount : ToppingDecorator
    {
        public Discount(AProduct product) : base(product) { }
        public override void addDiscount_price()
        {
            this.product.Price+= 20;
        }
    }
}
