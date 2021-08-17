using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class ProductFactory 
    {
        public static AProduct creatProductObject(IProductAbstractFactory caf)
        {
            return caf.creatProductObject();
        }
    }
}
