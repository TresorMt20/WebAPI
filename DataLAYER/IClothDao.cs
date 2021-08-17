using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;

namespace DataLAYER
{
  public  interface IClothDao
    {
        void AddCloths(Cloth cloth);
        List<Cloth> Getcloths();
    }
}
