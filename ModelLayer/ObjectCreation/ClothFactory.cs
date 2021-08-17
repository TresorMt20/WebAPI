using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class ClothFactory : IProductAbstractFactory
    {
        public AProduct creatProductObject()
        {
            return new Cloth();
        }
    }
}
