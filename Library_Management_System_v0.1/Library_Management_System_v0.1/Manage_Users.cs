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
            loadTable();
        }

        void loadTable()
        {
            String selectProfileType_SQL;
            String userRole = LoginDetails.userRole;
            selectProfileType_SQL = "SELECT * FROM user_profile";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_Profile = new MySqlCommand(selectProfileType_SQL, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlDataReader DataReader;
            DataReader = cmd_Profile.ExecuteReader();

            //id, generatedID, firstName, lastName, mobileNumber, landLineNumber, permenentAddress, residentAddress, isResidentSame, birthday, profileImageUrl, createDateTime, updateDateTime, isActive, user_login_history_id, user_profile_type_id
            while (DataReader.Read())
            {
                String id = DataReader.GetString("generatedID");
                String firstName = DataReader.GetString("firstName");
                String lastName = DataReader.GetString("lastName");
                String mobileNumber = DataReader.GetString("mobileNumber");
                String permenentAddress = DataReader.GetString("permenentAddress");
                String createDateTime = DataReader.GetString("createDateTime");
                String isActive = DataReader.GetString("isActive");
                String status = "";
                if (isActive.Equals("True"))
                {
                    status = "Active";
                }
                else
                {
                    status = "Deactive";
                }
                dataGridView1.Rows.Add(id, firstName, lastName, mobileNumber, permenentAddress, createDateTime, status);
            }
              
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {

        }

        
    }
}
