using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public class VehicleDrivers
    {
        private string _Dni;
        private string _VehicleRegistration;

        public string Dni
        {
            get
            {
                return _Dni;
            }
            set
            {
                _Dni = value;
            }
        }

        public string VehicleRegistration
        {
            get
            {
                return _VehicleRegistration;
            }
            set
            {
                _VehicleRegistration = value;
            }
        }

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