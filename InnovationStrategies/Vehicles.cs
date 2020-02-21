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
        /// <summary>
        /// DNI del conductor habitual
        /// </summary>
        private string _Dni;
        /// <summary>
        /// Matrícula del vehículo
        /// </summary>
        private string _VehicleRegistration;
    
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

        public string Brand
        {
            get
            {
                return _Brand;
            }
            set
            {
                _Brand = value;
            }
        }

        public string Model
        {
            get
            {
                return _Model;
            }
            set
            {
                _Model = value;
            }
        }

        /// <summary>
        /// Dni del conductor
        /// </summary>
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

            //El campo POINTS está predeterminado en base de datos por eso no se incluye en la sentencia insert.           
            cmd.CommandText = "INSERT INTO vehicles(vehicleregistration, brand, model, dni) VALUES ('" + VehicleRegistration + "', '" + Brand + "', '" + Model + "', '" + Dni + "')";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Comprueba si el vehículo ya existe en el sistema mirando su matrícula o VehicleRegistration
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
    }
}
