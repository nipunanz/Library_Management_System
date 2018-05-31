using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MySqlConnection mySqlConnection = null ;
            try
            {
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                mySqlConnection.Close();
                Application.Run(new Login());
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error - Please check the connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
            
            
        }
    }
}
