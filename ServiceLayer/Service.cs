using System;
using System.Collections.Generic;
using System.Text;
using DataLAYER;
using ModelLayer;

namespace ServiceLayer
{
  public  class Service:IService
    {
       // static readonly 
            IClothDao iClothDao = new ClothDao();

        public Service() { }
        public void AddCloths(Cloth cloth)
        {
            iClothDao.AddCloths(cloth);
        }

        public List<Cloth> Getcloths()
        {
            return iClothDao.Getcloths();
        }

        
    }
}
