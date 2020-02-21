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
        private int _Points;
        private int _NumberInfringement;
        private string _Infringement;
    
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

        public string Infringement
        {
            get
            {
                return _Infringement;
            }
            set
            {
                _Infringement = value;
            }
        }

        public int Points
        {
            get
            {
                return _Points;
            }
            set
            {
                _Points = value;
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

            //El campo NUMBER que identifica el tipo de infracción está definido como auto-incrementable en base de datos           
            cmd.CommandText="INSERT INTO infringementtype(Infringement, Points) VALUES ('" + Infringement + "', " + Points + ")";

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Devuelve todos los registros almacenados
        /// </summary>
        public static DataTable GetAll()
        {
            MySqlCommand cmd = InnovationStrategies.ConnectionBD.Cn.CreateCommand();

            cmd.CommandText = "SELECT number, infringement FROM infringementtype ORDER BY number";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt=new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
