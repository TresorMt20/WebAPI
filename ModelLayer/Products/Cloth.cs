using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    enum Type
    {
        men,
        women,
        children,
        babies,
        teenagers
    }
    enum Color
    {
        blue,
        dark,
        white,
        yellow,
        red
    }
    public class Cloth:AProduct
    {
        Type type;
        Color color;
        string madeIn;

        public Cloth() { }


    }

   
}
