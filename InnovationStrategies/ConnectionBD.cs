using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace InnovationStrategies
{
    class ConnectionBD
    {
        //private MySqlConnection mCn;

        public static MySqlConnection Cn
        {
            get
            {
                MySqlConnectionStringBuilder msb = new MySqlConnectionStringBuilder();

                msb.Server="localhost"; 
                msb.Database="InnovationStrategies";
                msb.UserID="root";
                msb.Password="cvmenci2014";

                MySqlConnection mCn = new MySqlConnection(msb.ToString());

                mCn.Open();

                return mCn;
            }
        } 
    }
}
