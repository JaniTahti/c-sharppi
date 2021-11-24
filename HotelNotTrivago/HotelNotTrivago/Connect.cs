using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelNotTrivago
{
    class Connect
    {
        private MySqlConnection connection = new MySqlConnection("datasource=loaclhost;port=3306;username=root;database=Csharp_Hotel_DB SSL Mode = None");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
