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
            String getReadersSql = "SELECT generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status FROM user_profile inner join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id WHERE user_profile_type.name = 'Reader'";
            String getLibrariansSql = "select generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status from user_profile left join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id left join user_login on user_profile.id = user_login.user_profile_id left join user_role on user_login.user_role_id = user_role.id WHERE user_role.name = 'Librarian'";
            String userRole = LoginDetails.userRole;

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();

            if (userRole.Equals("Librarian")) {
                MySqlCommand cmd_Profile = new MySqlCommand(getReadersSql, mySqlConnection);
                MySqlDataReader DataReader = cmd_Profile.ExecuteReader();

                while (DataReader.Read())
                {
                    String id = DataReader.GetString("generatedID");
                    String firstName = DataReader.GetString("firstName");
                    String lastName = DataReader.GetString("lastName");
                    String userProfileType = DataReader.GetString("userProfileType");
                    String mobileNumber = DataReader.GetString("mobileNumber");
                    String permenentAddress = DataReader.GetString("permenentAddress");
                    String createDateTime = DataReader.GetString("userRegDate");
                    String isActive = DataReader.GetString("status");
                    String status = "";
                    if (isActive.Equals("True"))
                    {
                        status = "Active";
                    }
                    else
                    {
                        status = "Deactive";
                    }
                    dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                }

            } if (userRole.Equals("Administrative Librarian")) {
                MySqlCommand cmd_Profile = new MySqlCommand(getLibrariansSql, mySqlConnection);
                MySqlDataReader DataReader = cmd_Profile.ExecuteReader();
                while (DataReader.Read())
                {
                    String id = DataReader.GetString("generatedID");
                    String firstName = DataReader.GetString("firstName");
                    String lastName = DataReader.GetString("lastName");
                    String userProfileType = DataReader.GetString("userProfileType");
                    String mobileNumber = DataReader.GetString("mobileNumber");
                    String permenentAddress = DataReader.GetString("permenentAddress");
                    String createDateTime = DataReader.GetString("userRegDate");
                    String isActive = DataReader.GetString("status");
                    String status = "";
                    if (isActive.Equals("True"))
                    {
                        status = "Active";
                    }
                    else
                    {
                        status = "Deactive";
                    }
                    dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);
                }
                DataReader.Close();

                MySqlCommand cmd_Profile2 = new MySqlCommand(getReadersSql, mySqlConnection);
                MySqlDataReader DataReader2 = cmd_Profile2.ExecuteReader();

                while (DataReader2.Read())
                {
                    String id = DataReader2.GetString("generatedID");
                    String firstName = DataReader2.GetString("firstName");
                    String lastName = DataReader2.GetString("lastName");
                    String userProfileType = DataReader2.GetString("userProfileType");
                    String mobileNumber = DataReader2.GetString("mobileNumber");
                    String permenentAddress = DataReader2.GetString("permenentAddress");
                    String createDateTime = DataReader2.GetString("userRegDate");
                    String isActive = DataReader2.GetString("status");
                    String status = "";
                    if (isActive.Equals("True"))
                    {
                        status = "Active";
                    }
                    else
                    {
                        status = "Deactive";
                    }
                    dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                }
            }




            mySqlConnection.Close();
              
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {

        }

        private void buttonActivateDeactivate_Click(object sender, EventArgs e)
        {

            try
            {
                String currectId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String currentStatus = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //Console.WriteLine("Selected Row :"+currectId+" Status :"+currentStatus);
                if (currentStatus.Equals("Active"))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Deactivate this user", "Manage user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        String deactivateUser = "UPDATE user_profile SET isActive = 0 WHERE generatedID = @currentId";
                        MySqlConnection sqlConnection = DataConnection.getDBConnection();
                        sqlConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(deactivateUser, sqlConnection);
                        mySqlCommand.CommandText = deactivateUser;
                        mySqlCommand.Parameters.AddWithValue("@currentId", currectId);
                        mySqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Successfully Deactivated!", "Manage user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.RowCount = 0;
                        loadTable();
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Activate this user", "Register new user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        String deactivateUser = "UPDATE user_profile SET isActive = 1 WHERE generatedID = @currentId";
                        MySqlConnection sqlConnection = DataConnection.getDBConnection();
                        sqlConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(deactivateUser, sqlConnection);
                        mySqlCommand.CommandText = deactivateUser;
                        mySqlCommand.Parameters.AddWithValue("@currentId", currectId);
                        mySqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Successfully Activated!", "Manage user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.RowCount = 0;
                        loadTable();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            

        }

        private void textBoxBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBoxBookID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String searchVal = textBoxBookID.Text;
                dataGridView1.RowCount = 0;
                String getReadersSql = "SELECT generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status FROM user_profile inner join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id WHERE user_profile_type.name = 'Reader' AND generatedID like @searchVal";
                String getLibrariansSql = "select generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status from user_profile left join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id left join user_login on user_profile.id = user_login.user_profile_id left join user_role on user_login.user_role_id = user_role.id WHERE user_role.name = 'Librarian' AND generatedID like @searchVal";
                String userRole = LoginDetails.userRole;

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                if (userRole.Equals("Librarian"))
                {
                    MySqlCommand cmd_Profile = new MySqlCommand(getReadersSql, mySqlConnection);
                    MySqlDataReader DataReader = cmd_Profile.ExecuteReader();

                    while (DataReader.Read())
                    {
                        String id = DataReader.GetString("generatedID");
                        String firstName = DataReader.GetString("firstName");
                        String lastName = DataReader.GetString("lastName");
                        String userProfileType = DataReader.GetString("userProfileType");
                        String mobileNumber = DataReader.GetString("mobileNumber");
                        String permenentAddress = DataReader.GetString("permenentAddress");
                        String createDateTime = DataReader.GetString("userRegDate");
                        String isActive = DataReader.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                    }

                }
                if (userRole.Equals("Administrative Librarian"))
                {
                    MySqlCommand cmd_Profile = new MySqlCommand(getLibrariansSql, mySqlConnection);
                    cmd_Profile.CommandText = getLibrariansSql;
                    cmd_Profile.Parameters.AddWithValue("@searchVal", "%" + searchVal + "%");
                    MySqlDataReader DataReader = cmd_Profile.ExecuteReader();

                    while (DataReader.Read())
                    {
                        String id = DataReader.GetString("generatedID");
                        String firstName = DataReader.GetString("firstName");
                        String lastName = DataReader.GetString("lastName");
                        String userProfileType = DataReader.GetString("userProfileType");
                        String mobileNumber = DataReader.GetString("mobileNumber");
                        String permenentAddress = DataReader.GetString("permenentAddress");
                        String createDateTime = DataReader.GetString("userRegDate");
                        String isActive = DataReader.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);
                    }
                    DataReader.Close();

                    MySqlCommand cmd_Profile2 = new MySqlCommand(getReadersSql, mySqlConnection);
                    cmd_Profile2.CommandText = getReadersSql;
                    cmd_Profile2.Parameters.AddWithValue("@searchVal", "%" + searchVal + "%");
                    MySqlDataReader DataReader2 = cmd_Profile2.ExecuteReader();

                    while (DataReader2.Read())
                    {
                        String id = DataReader2.GetString("generatedID");
                        String firstName = DataReader2.GetString("firstName");
                        String lastName = DataReader2.GetString("lastName");
                        String userProfileType = DataReader2.GetString("userProfileType");
                        String mobileNumber = DataReader2.GetString("mobileNumber");
                        String permenentAddress = DataReader2.GetString("permenentAddress");
                        String createDateTime = DataReader2.GetString("userRegDate");
                        String isActive = DataReader2.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBoxBookName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String searchVal = textBoxBookName.Text;
                dataGridView1.RowCount = 0;
               // loadTable();
                String getReadersSql = "SELECT generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status FROM user_profile inner join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id WHERE user_profile_type.name = 'Reader' AND (firstName like @searchVal OR lastName like @searchVal)";
                String getLibrariansSql = "SELECT generatedID, firstName, lastName, user_profile_type.name as userProfileType, mobileNumber, permenentAddress, user_profile.createDateTime as userRegDate, user_profile.isActive as status from user_profile left join user_profile_type on user_profile.user_profile_type_id = user_profile_type.id left join user_login on user_profile.id = user_login.user_profile_id left join user_role on user_login.user_role_id = user_role.id WHERE user_role.name = 'Librarian' AND (firstName like @searchVal OR lastName like @searchVal)";
                String userRole = LoginDetails.userRole;

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                if (userRole.Equals("Librarian"))
                {
                    MySqlCommand cmd_Profile = new MySqlCommand(getReadersSql, mySqlConnection);
                    MySqlDataReader DataReader = cmd_Profile.ExecuteReader();

                    while (DataReader.Read())
                    {
                        String id = DataReader.GetString("generatedID");
                        String firstName = DataReader.GetString("firstName");
                        String lastName = DataReader.GetString("lastName");
                        String userProfileType = DataReader.GetString("userProfileType");
                        String mobileNumber = DataReader.GetString("mobileNumber");
                        String permenentAddress = DataReader.GetString("permenentAddress");
                        String createDateTime = DataReader.GetString("userRegDate");
                        String isActive = DataReader.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                    }

                }
                if (userRole.Equals("Administrative Librarian"))
                {
                    MySqlCommand cmd_Profile = new MySqlCommand(getLibrariansSql, mySqlConnection);
                    cmd_Profile.CommandText = getLibrariansSql;
                    cmd_Profile.Parameters.AddWithValue("@searchVal", "%" + searchVal + "%");
                    MySqlDataReader DataReader = cmd_Profile.ExecuteReader();

                    while (DataReader.Read())
                    {
                        String id = DataReader.GetString("generatedID");
                        String firstName = DataReader.GetString("firstName");
                        String lastName = DataReader.GetString("lastName");
                        String userProfileType = DataReader.GetString("userProfileType");
                        String mobileNumber = DataReader.GetString("mobileNumber");
                        String permenentAddress = DataReader.GetString("permenentAddress");
                        String createDateTime = DataReader.GetString("userRegDate");
                        String isActive = DataReader.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);
                    }
                    DataReader.Close();

                    MySqlCommand cmd_Profile2 = new MySqlCommand(getReadersSql, mySqlConnection);
                    cmd_Profile2.CommandText = getReadersSql;
                    cmd_Profile2.Parameters.AddWithValue("@searchVal", "%" + searchVal + "%");
                    MySqlDataReader DataReader2 = cmd_Profile2.ExecuteReader();

                    while (DataReader2.Read())
                    {
                        String id = DataReader2.GetString("generatedID");
                        String firstName = DataReader2.GetString("firstName");
                        String lastName = DataReader2.GetString("lastName");
                        String userProfileType = DataReader2.GetString("userProfileType");
                        String mobileNumber = DataReader2.GetString("mobileNumber");
                        String permenentAddress = DataReader2.GetString("permenentAddress");
                        String createDateTime = DataReader2.GetString("userRegDate");
                        String isActive = DataReader2.GetString("status");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }
                        dataGridView1.Rows.Add(id, firstName, lastName, userProfileType, mobileNumber, permenentAddress, createDateTime, status);

                    }
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                String currectId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String userType = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Add_New_User add_New_User = new Add_New_User(currectId, userType);
                add_New_User.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error \n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            loadTable();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
