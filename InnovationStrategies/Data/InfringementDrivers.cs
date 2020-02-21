﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace InnovationStrategies
{
    public class InfringementDrivers : IInfringementDrivers
    {
        private int _NumberInfringement;
        private string _Dni;
        private DateTime _Date;
        private string _VehicleRegistration;

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
        /// Add a violation and call the Drivers.Sanction method to discount the corresponding points
        /// </summary>
        public void Add()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "INSERT INTO infringementdrivers(date, dni, numberinfringement, vehicleregistration) VALUES ('" + Date.ToString("yyyy-MM-dd HH:mm") + "', '" + Dni + "', " + NumberInfringement + ", '" + VehicleRegistration + "')";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Returns all stored records of a driver
        /// </summary>
        public static DataTable GetByDriver(string dni)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT date as Fecha, infringement as Infraccion, vehicleregistration as Matricula FROM infringementdrivers id INNER JOIN infringementtype it ON id.numberinfringement=it.number WHERE dni='" + dni + "' ORDER BY date";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Returns the 5 most common infringements
        /// </summary>
        public static DataTable HabitualInfractions()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT Infringement as Infraccion, COUNT(numberinfringement) as Total FROM infringementdrivers id INNER JOIN infringementtype it ON id.NumberInfringement = it.Number GROUP BY NumberInfringement ORDER BY Total DESC LIMIT 5";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
