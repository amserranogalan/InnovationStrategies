using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace InnovationStrategies
{
    public class Drivers
    {
        private string _Dni;
        private string _Name;
        private string _Surnames;
        private int _points;
    
        public string Dni { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
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

        public VehicleDrivers VehiclesDrivers
        {
            get => default(VehicleDrivers);
            set
            {
            }
        }

        public Drivers()
        { }

        public Drivers(string dni)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT dni, name, surnames, points FROM drivers WHERE dni='" + dni + "'";

            MySqlDataReader mdr;

            mdr = cmd.ExecuteReader();

            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    Dni=dni;
                    Name=mdr.GetString("name");
                    Surnames=mdr.GetString("surnames");
                    Points=mdr.GetInt32("points");
                }
            }
            
            mdr.Close();
        }

        /// <summary>
        /// Add new Driver.
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            //The POINTS field is predetermined in database so it is not included in the insert statement.        
            cmd.CommandText = "INSERT INTO drivers(dni, name, surnames) VALUES ('" + Dni + "', '" + Name + "', '" + Surnames + "')";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Check if there is a customer with the same DNI
        /// </summary>
        public bool Exist()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM drivers WHERE dni='" + Dni + "'";

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Check if there is a customer with the same DNI received as a parameter.
        /// </summary>
        public static bool Exist(string dni)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM drivers WHERE dni='" + dni + "'";

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Execute the sanction by removing the points
        /// </summary>
        public void Sanction(int points)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "UPDATE drivers SET points=points-" + points;

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Returns the number of vehicles of which this driver is a regular driver
        /// </summary>
        public static int TotalVehicles(string dni)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM vehicles WHERE dni='" + dni + "'";

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }

        /// <summary>
        /// Returns the TOP N of drivers with the most points
        /// </summary>
        public static DataTable Top(int n)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT dni as DNI, concat(name, ' ', surnames) as Conductor, points as Puntos FROM drivers ORDER BY points DESC LIMIT " + n;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
