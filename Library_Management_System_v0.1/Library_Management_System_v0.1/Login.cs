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

            //+++++++++ null & empty check for input values +++++++++//
            if ((email == null || email.Equals("")) && (password == null || password.Equals(""))) {
                MessageBox.Show("Email or Password Can't be Empty", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String loginQuery = "SELECT * FROM user_login WHERE emailAddress = @email";
                String getUserRole = "SELECT * FROM user_role WHERE id = @userRoleId";
                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(loginQuery, mySqlConnection);
                command.CommandText = loginQuery;
                command.Parameters.AddWithValue("@email", email);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    while (mySqlDataReader.Read()) {
                        String encPassword = mySqlDataReader.GetString("password");
                        String decPassword = StringCipher.Decrypt(encPassword, LoginDetails.passwordKey);
                        if (password.Equals(decPassword))
                        {
                            String userRoleId = mySqlDataReader.GetString("user_role_id");
                            MySqlCommand commandGetUserRole = new MySqlCommand(getUserRole, mySqlConnection);
                            commandGetUserRole.CommandText = getUserRole;
                            commandGetUserRole.Parameters.AddWithValue("@userRoleId", userRoleId);
                            mySqlDataReader.Close();
                            MySqlDataReader mySqlDataReader2 = commandGetUserRole.ExecuteReader();
                            if (mySqlDataReader2.HasRows)
                            {
                                mySqlDataReader2.Read();
                                LoginDetails.userRole = mySqlDataReader2.GetString("name");
                                if (LoginDetails.userRole.Equals("Administrative Librarian")) {
                                    Home home = new Home();
                                    home.Show();
                                }
                                else
                                {
                                    Home home = new Home("librarian");
                                    home.Show();
                                }
                                this.Hide();

                                break;
                            }
                            else
                            {
                                MessageBox.Show("User type does not exists", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Account does not exists", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                mySqlConnection.Close();
            }
            
        }
    }
}
