using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    public class DataConnection
    {
       static MySqlConnection mySqlConnection;
       
       public static MySqlConnection getDBConnection()
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            mySqlConnectionStringBuilder.Server = "localhost";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "123";
            mySqlConnectionStringBuilder.Database = "nanofoxy_library_management_system";

            if (DataConnection.mySqlConnection == null) {

                MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ToString());
                mySqlConnection.Open();

            }

            return mySqlConnection;
        }

    }
}
