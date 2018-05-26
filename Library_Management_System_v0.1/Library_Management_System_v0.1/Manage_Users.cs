using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    public partial class Manage_Users : Form
    {
        public Manage_Users()
        {
            InitializeComponent();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {

        }

        private void loadTable()
        {
            String selectProfileDetails_SQL = "SELECT (id, generatedID, firstName, lastName, mobileNumber, permenentAddress, birthday, isActive) FROM user_profile_type";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_Profile = new MySqlCommand(selectProfileDetails_SQL, mySqlConnection);
            
            cmd_Profile.ExecuteNonQuery();
            DataTable dt = new DataTable();
            
        }
    }
}
