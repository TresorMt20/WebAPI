using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;
using System.Data.SqlClient;


namespace DataLAYER
{
 public class Db
    {
        public static string connectionsString { get; set; }

        static Db instance;
        public List<Cloth> cloths { get; set; }
        public Db(string connect)
        {
            if (Db.connectionsString == null) connectionsString = "setconnection";
            else Db.connectionsString = connect;

            

            SqlConnection con = new SqlConnection();





        }

        public static Db GetInstance()
        {
            if (instance == null) return new Db(connectionsString);
            return instance;
        }

        public void InsertCloth(Cloth cloth) { cloths.Add(cloth); }
        public List<Cloth> getcloths() { return cloths; }

        

    }
}
