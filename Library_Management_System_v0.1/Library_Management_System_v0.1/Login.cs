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
using System.Drawing;

namespace Library_Management_System_v0._1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //+++++++++ get input values from login form +++++++++//
            String email = textBoxEmail.Text;
            String password = textBoxPassword.Text;

            MySqlConnection mySqlConnection = null;
            try
            {
                //+++++++++ null & empty check for input values +++++++++//
                if ((email == null || email.Equals("")) && (password == null || password.Equals("")))
                {
                    MessageBox.Show("Email or Password Can't be Empty", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String loginQuery = "SELECT * FROM user_login WHERE emailAddress = @email";
                    String getUserRole = "SELECT * FROM user_role WHERE id = @userRoleId";
                    String insertLoginHistory = "INSERT INTO user_login_history (loginDateTime, logoutDateTime, user_login_id) VALUES (@loginDateTime, null, @user_login_id)";
                    String getLoginHistoryID = "SELECT * FROM user_login_history WHERE loginDateTime = @currentDate";

                    DateTime dateTime = DateTime.Now;
                    dateTime.ToString("yyyyMMddHHmmss");

                    mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(loginQuery, mySqlConnection);
                    command.CommandText = loginQuery;
                    command.Parameters.AddWithValue("@email", email);
                    MySqlDataReader mySqlDataReader = command.ExecuteReader();

                    if (mySqlDataReader.HasRows)
                    {
                        while (mySqlDataReader.Read())
                        {

                            String encPassword = mySqlDataReader.GetString("password");
                            String decPassword = StringCipher.Decrypt(encPassword, LoginDetails.passwordKey);

                            if (password.Equals(decPassword))
                            {
                                String userRoleId = mySqlDataReader.GetString("user_role_id");
                                String userLoginId = mySqlDataReader.GetString("id");
                                LoginDetails.userLoginId = userLoginId;

                                MySqlCommand commandGetUserRole = new MySqlCommand(getUserRole, mySqlConnection);
                                commandGetUserRole.CommandText = getUserRole;
                                commandGetUserRole.Parameters.AddWithValue("@userRoleId", userRoleId);

                                MySqlCommand commandInsertLoginHistory = new MySqlCommand(insertLoginHistory, mySqlConnection);
                                commandInsertLoginHistory.CommandText = insertLoginHistory;
                                commandInsertLoginHistory.Parameters.AddWithValue("@loginDateTime", dateTime);
                                commandInsertLoginHistory.Parameters.AddWithValue("@user_login_id", userLoginId);

                                mySqlDataReader.Close();

                                commandInsertLoginHistory.ExecuteNonQuery();

                                MySqlDataReader mySqlDataReader2 = commandGetUserRole.ExecuteReader();
                                if (mySqlDataReader2.HasRows)
                                {
                                    mySqlDataReader2.Read();
                                    LoginDetails.userRole = mySqlDataReader2.GetString("name");
                                    if (LoginDetails.userRole.Equals("Administrative Librarian"))
                                    {
                                        Home home = new Home();
                                        home.Show();
                                    }
                                    else
                                    {
                                        Home home = new Home("librarian");
                                        home.Show();
                                    }
                                    mySqlDataReader2.Close();
                                    MySqlCommand commandGetLoginHistoryId = new MySqlCommand(getLoginHistoryID, mySqlConnection);
                                    commandGetLoginHistoryId.CommandText = getLoginHistoryID;
                                    commandGetLoginHistoryId.Parameters.AddWithValue("@currentDate", dateTime);

                                    MySqlDataReader loginHistoryReader = commandGetLoginHistoryId.ExecuteReader();
                                    if (loginHistoryReader.Read())
                                    {
                                        LoginDetails.userLoginHistoryID = loginHistoryReader.GetString("id");
                                    }
                                                                        
                                    //MessageBox.Show("Login History ID : "+LoginDetails.userLoginHistoryID);
                                    loginHistoryReader.Close();


                                    this.Hide();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("User type does not exists", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxPassword.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account does not exists", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxEmail.Text = "";
                    }

                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                mySqlConnection.Close();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            linkLabel1.BackColor = Color.Transparent;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
