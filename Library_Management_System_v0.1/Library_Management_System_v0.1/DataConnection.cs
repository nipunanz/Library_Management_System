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
          
            String conStr = "server=localhost;user id=root;password=123;persistsecurityinfo=True;port=3306;database=nanofoxy_library_management_system;SslMode=none";

            if (DataConnection.mySqlConnection == null) {

                mySqlConnection = new MySqlConnection(connectionString: conStr);

            }
            mySqlConnection.Open();
            return mySqlConnection;
        }

    }
}
