using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace InnovationStrategies
{
    public class InfringementType
    {
        public int NumberInfringement { get; set; }
        public string Infringement { get; set; }
        public int Points { get; set; }
        public InfringementDrivers InfringementDrivers
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public InfringementType()
        { }

        public InfringementType(int number)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT infringement, points FROM infringementtype WHERE number=" + number;

            MySqlDataReader mdr;
            
            mdr= cmd.ExecuteReader();

            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    NumberInfringement=number;
                    Infringement = mdr.GetString("infringement");
                    Points=mdr.GetInt32("points");
                }
            }
            
            mdr.Close();
        }

        /// <summary>
        /// Add new Infringement Type.
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            //The NUMBER field that identifies the type of violation is defined as self-incremental in database          
            cmd.CommandText="INSERT INTO infringementtype(Infringement, Points) VALUES ('" + Infringement + "', " + Points + ")";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Return all stored records
        /// </summary>
        public static DataTable GetAll()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT number, infringement FROM infringementtype ORDER BY number";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
