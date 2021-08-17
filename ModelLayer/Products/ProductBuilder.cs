using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
   public class ProductBuilder
    {
        AProduct product;
        public ProductBuilder(AProduct product )
        {
            this.product = product;
        }

        public ProductBuilder setprice(int price)
        {
            product.Price = price;
            return this;
        }
        public ProductBuilder setname(string name)
        {
            product.Name = name;
            return this;
        }
        public ProductBuilder setdescription(string description)
        {
            product.Description = description;
            return this;
        }
        public ProductBuilder setimagigeurl(string magigeurl)
        {
            product.Image = magigeurl;
            return this;
        }
       

        public AProduct Build()
        {
            return this.product;
        }
    }
}
