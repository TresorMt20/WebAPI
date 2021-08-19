using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;
using System.Data.SqlClient;
using System.Data;


namespace DataLAYER
{
 public class Db
    {
       // public static string connectionsString { get; set; }

        static Db instance;
        static string connetionString = @"Data Source = DESKTOP-N5H4A1E; Initial Catalog = zandoDb; Integrated Security = True";
        public List<Cloth> clot;

        public Db() 
        {
            clot = new List<Cloth>();
            //con.Close();
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM cloth", con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                //  Console.WriteLine("Emp Id\t\t\t\t\t Name \t\t\t\t\t\t EmpNo\t");
                while (reader.Read())
                {
                    string a=reader.GetString(2);
                    string b= reader.GetString(1);
                    //  String.Format("{0} \t\t\t | {1} \t | {2}", reader[0], reader[1], reader[2]);

                    Cloth hh = new Cloth();

                    hh.Name = b;
                    hh.Description = a;

                    clot.Add(hh);

                }
            }
            con.Close();


        }
        public Db(string connect)
        {
            //if (Db.connectionsString == null) connectionsString = connetionString;
            //else Db.connectionsString = connect;


            ////cnn = new SqlConnection(connetionString);
            ////cnn.Open();

            //SqlConnection connection = new SqlConnection(connetionString);
            //string query = "INSERT INTO cloth (name,description) VALUES('anith.','$1200')";
            //SqlCommand command = new SqlCommand(query, connection);
            //try
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    // Console.WriteLine("Records Inserted Successfully");
            //}
            //catch (SqlException e)
            //{
            //    // Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            //finally
            //{
            //    connection.Close();
            //}


            //using (SqlConnection con = new SqlConnection(connetionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SELECT * FROM cloth", con))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //        {
            //            using (DataTable dt = new DataTable())
            //            {
            //                sda.Fill(dt);
            //                dt.
            //            }
            //        }
            //    }
            //}


        }

        //public static Db GetInstance()
        //{
        //    //if (instance == null) return new Db(connectionsString);
        //    //return instance;

        //    //if (Db.instance == null)
        //    //    Db.instance = new Db();
        //    //return instance;

        //}

        public void InsertCloth(Cloth cloth) 
        { 


            clot.Add(cloth);

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string insertquery = "INSERT INTO cloth (id,name,description) VALUES('" + cloth.Id + "','" + cloth.Name + "','" + cloth.Description + "')";

            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.ExecuteNonQuery();

            con.Close();

        }
        public List<Cloth> getcloths() 
        {
            
            return clot; 
        }

        

    }
}
