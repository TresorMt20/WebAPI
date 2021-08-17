using System;
using System.Collections.Generic;
using System.Text;
using DataLAYER;
using ModelLayer;

namespace ServiceLayer
{
 public interface IService
    {
        void AddCloths(Cloth cloth);
        List<Cloth> Getcloths();
    }
}
