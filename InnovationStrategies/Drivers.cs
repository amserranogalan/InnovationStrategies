using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    public class Drivers
    {
        private string _Dni;
        private string _Name;
        private string _Surnames;
        private int _points;
    
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

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Surnames
        {
            get
            {
                return _Surnames;
            }
            set
            {
                _Surnames = value;
            }
        }

        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

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

            //El campo POINTS está predeterminado en base de datos por eso no se incluye en la sentencia insert.           
            cmd.CommandText = "INSERT INTO drivers(dni, name, surnames) VALUES ('" + Dni + "', '" + Name + "', '" + Surnames + "')";

            cmd.ExecuteNonQuery();
        }

        /// <summary>Comprueba si existe un cliente con el mismo DNI que se quiere introducir.</summary>
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

        /// <summary>Comprueba si existe un cliente con el mismo DNI recibido como parámetro.</summary>
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
        /// Ejecuta la sanción quitando los puntos correspondientes
        /// </summary>
        public void Sanction(int points)
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();
       
            cmd.CommandText = "UPDATE drivers SET points=points-" + points;

            cmd.ExecuteNonQuery();
        }
    }
}
