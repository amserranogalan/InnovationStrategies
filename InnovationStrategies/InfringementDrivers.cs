using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public class InfringementDrivers
    {
        private int _NumberInfringement;
        private string _Dni;
        private DateTime _Date;
        private string _VehicleRegistration;
        /// <summary>
        /// Número de infracción
        /// </summary>
        public int NumberInfringement
        {
            get
            {
                return _NumberInfringement;
            }
            set
            {
                _NumberInfringement = value;
            }
        }

        /// <summary>
        /// Dni del conductor que ha cometido la infracción
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

        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }

        /// <summary>
        /// Matrícula del vehículo en el que se ha cometido la infracción
        /// </summary>
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
        /// Añade una infracción y llama al metodo Drivers.Sanction para descontar los puntos correspondientes
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "INSERT INTO infringementdrivers(date, dni, numberinfringement, vehicleregistration) VALUES ('" + Date.ToString("yyyy-MM-dd HH:mm") + "', '" + Dni + "', " + NumberInfringement + ", '" + VehicleRegistration + "')";

            cmd.ExecuteNonQuery();
        }
    }
}
