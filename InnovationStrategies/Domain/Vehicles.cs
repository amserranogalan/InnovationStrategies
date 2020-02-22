using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public class Vehicles
    {
        private string _Brand;
        private string _Model;
        private string _Dni;
        private string _VehicleRegistration;
    
        public string VehicleRegistration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Dni { get; set; }
        public VehicleDrivers VehiclesDrivers
        {
            get => default(VehicleDrivers);
            set
            {
            }
        }

        public Vehicles()
        { }

        public Vehicles(string vehicleregistration)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT vehicleregistration, brand, model, dni FROM vehicles WHERE vehicleregistration='" + vehicleregistration + "'";

            MySqlDataReader mdr;

            mdr = cmd.ExecuteReader();

            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    VehicleRegistration = vehicleregistration;
                    Brand = mdr.GetString("brand");
                    Model = mdr.GetString("model");
                    Dni = mdr.GetString("dni");
                }
            }
            
            mdr.Close();
        }

        /// <summary>
        /// Add new vehicle
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();
                
            cmd.CommandText = "INSERT INTO vehicles(vehicleregistration, brand, model, dni) VALUES ('" + VehicleRegistration + "', '" + Brand + "', '" + Model + "', '" + Dni + "')";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Check if the vehicle already exists in the system by looking at its vehicle registration
        /// </summary>
        public bool Exist()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM vehicles WHERE vehicleregistration='" + VehicleRegistration + "'";

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
        public static bool Exist(string vehicleregistration)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT count(*) FROM vehicles WHERE vehicleregistration='" + vehicleregistration + "'";

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
    }
}
