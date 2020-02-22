using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public class VehicleDrivers
    {
        public string Dni { get; set; }
        public string VehicleRegistration { get; set; }

        /// <summary>
        /// Add driver to vehicle
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();
         
            cmd.CommandText = "INSERT INTO vehicledrivers(dni, vehicleregistration) VALUES ('" + Dni + "', '" + VehicleRegistration + "')";

            cmd.ExecuteNonQuery();
        }
    }
}