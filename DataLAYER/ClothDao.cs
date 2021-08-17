using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLAYER
{
    public class ClothDao : IClothDao
    {
        static Db db = Db.GetInstance();
        public void AddCloths(Cloth cloth)
        {
            db.InsertCloth(cloth);
        }

        public List<Cloth> Getcloths()
        {
            return db.getcloths();
        }
    }
}
