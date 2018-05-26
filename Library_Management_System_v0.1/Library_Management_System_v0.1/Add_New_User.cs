using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    public partial class Add_New_User : Form
    {
        public Add_New_User()
        {
            InitializeComponent();
            fillComboProfileType();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        String imageLoacation = null;
        bool isResidenceSame = false;

        void generateID()
        {

            DateTime dateObj = DateTime.Now; //Gets the current DATE/TIME

            String date = dateObj.Day.ToString("dd");//Gets the current DAY
            String month = dateObj.Month.ToString("MM");//Gets the current MONTH
            String year = dateObj.Year.ToString("yyyy");//Gets the current YEAR
            String searchDateFormat = year + "-" + month + "-" + date;//Format the date as per SQL Format

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();

            String searchDailyCount = "SELECT COUNT(id) FROM user_profile WHERE createDateTime LIKE @date ";
            MySqlCommand command_newUser = new MySqlCommand(searchDailyCount, mySqlConnection);
            command_newUser.CommandText = searchDailyCount;
            command_newUser.Parameters.AddWithValue("@date", "%" + dateObj.ToString(searchDateFormat) + "%");
            Object sqlResult = command_newUser.ExecuteScalar();
            int nextUserId = Convert.ToInt32(sqlResult.ToString()) + 1;
            labelUserId.Text = "UPR" + dateObj.ToString(date) + dateObj.ToString(year) + dateObj.ToString(month) + nextUserId;
            mySqlConnection.Close();

        }

        public void fillComboProfileType()
        {

            String selectProfileType_SQL = "SELECT * FROM user_profile_type";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_ProfileType = new MySqlCommand(selectProfileType_SQL, mySqlConnection);
            MySqlDataReader DataReaderBookType;

            DataReaderBookType = cmd_ProfileType.ExecuteReader();
            while (DataReaderBookType.Read())
            {
                String profileType = DataReaderBookType.GetString("name");
                comboBoxProfileType.Items.Add(profileType);

            }
            if (LoginDetails.userRole.Equals("Librarian")) {
                comboBoxProfileType.Items.Remove("Librarian");
            }

            mySqlConnection.Close();

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageLoacation = openFile.FileName.ToString();
                pictureBoxUser.ImageLocation = imageLoacation;
            }
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            if (imageLoacation != null && !imageLoacation.Equals("")) {
                FileStream fileStream = new FileStream(imageLoacation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fileStream);
                images = reader.ReadBytes((int)fileStream.Length);
            }

            String userId = labelUserId.Text;
            String fName = textBoxFirstName.Text;
            String lName = textBoxLastName.Text;
            String mobile = textBoxMobile.Text;
            String landNumber = textBoxLand.Text;
            String pAddress = textBoxPAddress.Text;
            String rAddress = textBoxRAddress.Text;
            String birthday = dateTimePickerBirthday.Text;
            bool isProfileTypeSelected = true;
            String email = textBoxEmail.Text;
            String password = textBoxPassword.Text;
            String rePassword = textBoxRePassword.Text;
            String profileType = "";
            String userRole = "Librarian";
            bool savePermission = false;

            String getProfileTypeIdSql = "SELECT id FROM user_profile_type WHERE name = @profileType";
            String saveUserProfileSql = "INSERT INTO user_profile (generatedID, firstName, lastName, mobileNumber, landLineNumber, permenentAddress, residentAddress, isResidentSame, birthday, profileImageUrl, createDateTime, updateDateTime, isActive, user_login_history_id, user_profile_type_id) VALUES (@generatedID, @firstName, @lastName, @mobileNumber, @landLineNumber, @permenentAddress, @residentAddress, @isResidentSame, @birthday, @profileImageUrl, @createDateTime, @updateDateTime, @isActive, @user_login_history_id, @user_profile_type_id)";
            String getUserRoleIdSql = "SELECT id FROM user_role WHERE name = @roleName";
            String getUserProfileIdSql = "SELECT id FROM user_profile WHERE generatedID = @userId";
            String saveUserLoginSql = "INSERT INTO user_login (emailAddress, password, createDateTime, updateDateTime, isActive, isOnline, user_role_id, user_profile_id) VALUES (@emailAddress, @password, @createDateTime, @updateDateTime, @isActive, @isOnline, @user_role_id, @user_profile_id)";

            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yyyyMMddHHmmss");

            try
            {
                profileType = comboBoxProfileType.SelectedItem.ToString();
            }
            catch
            {
                isProfileTypeSelected = false;
            }

            if (fName.Equals("") || lName.Equals("") || mobile.Equals("") || pAddress.Equals("") || rAddress.Equals("") || birthday.Equals(""))
            {
                MessageBox.Show("Some fields can't be Empty", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!isProfileTypeSelected)
            {
                MessageBox.Show("Please select the user profile type", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (profileType.Equals("Librarian"))
                {
                    if (email.Equals("") || password.Equals("") || rePassword.Equals(""))
                    {
                        MessageBox.Show("Authentication details can't be empty", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool adminCheck = checkBoxAdmin.Checked;

                        if (IsValidEmail(email))
                        {
                            if (isValidAccount(email))
                            {
                                if (password.Equals(rePassword))
                                {
                                    savePermission = true;
                                    if (adminCheck)
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to make this user as an Administrator. Changes can't be roll back", "Register new user", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                        if (dialogResult == DialogResult.OK)
                                        {
                                            userRole = "Administrative Librarian";
                                            savePermission = true;
                                        }
                                        else
                                        {
                                            savePermission = false;
                                        }
                                    }
                                    else
                                    {
                                        userRole = "Librarian";
                                    }

                                    if (savePermission)
                                    {

                                        MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                                        mySqlConnection.Open();
                                        MySqlCommand commandSaveLibrarian = new MySqlCommand(saveUserProfileSql, mySqlConnection);
                                        commandSaveLibrarian.CommandText = saveUserProfileSql;
                                        commandSaveLibrarian.Parameters.AddWithValue("@generatedID", userId);
                                        commandSaveLibrarian.Parameters.AddWithValue("@firstName", fName);
                                        commandSaveLibrarian.Parameters.AddWithValue("@lastName", lName);
                                        commandSaveLibrarian.Parameters.AddWithValue("@mobileNumber", mobile);
                                        commandSaveLibrarian.Parameters.AddWithValue("@landLineNumber", landNumber);
                                        commandSaveLibrarian.Parameters.AddWithValue("@permenentAddress", pAddress);
                                        commandSaveLibrarian.Parameters.AddWithValue("@residentAddress", rAddress);
                                        commandSaveLibrarian.Parameters.AddWithValue("@isResidentSame", isResidenceSame);
                                        commandSaveLibrarian.Parameters.AddWithValue("@birthday", birthday);
                                        if (imageLoacation != null)
                                        {
                                            commandSaveLibrarian.Parameters.AddWithValue("@profileImageUrl", images.ToString());
                                        }
                                        else
                                        {
                                            commandSaveLibrarian.Parameters.AddWithValue("@profileImageUrl", null);
                                        }
                                        commandSaveLibrarian.Parameters.AddWithValue("@createDateTime", dateTime);
                                        commandSaveLibrarian.Parameters.AddWithValue("@updateDateTime", null);
                                        commandSaveLibrarian.Parameters.AddWithValue("@isActive", 1);
                                        commandSaveLibrarian.Parameters.AddWithValue("@user_login_history_id", LoginDetails.userLoginHistoryID);

                                        MySqlCommand getProfileTypeId = new MySqlCommand(getProfileTypeIdSql, mySqlConnection);
                                        getProfileTypeId.CommandText = getProfileTypeIdSql;
                                        getProfileTypeId.Parameters.AddWithValue("profileType", profileType);
                                        MySqlDataReader readTypeId = getProfileTypeId.ExecuteReader();
                                        readTypeId.Read();

                                        commandSaveLibrarian.Parameters.AddWithValue("@user_profile_type_id", readTypeId.GetString("id"));
                                        readTypeId.Close();

                                        commandSaveLibrarian.ExecuteNonQuery();

                                        MySqlCommand getUserProfileId = new MySqlCommand(getUserProfileIdSql, mySqlConnection);
                                        getUserProfileId.CommandText = getUserProfileIdSql;
                                        getUserProfileId.Parameters.AddWithValue("@userId", userId);
                                        MySqlDataReader readProfileID = getUserProfileId.ExecuteReader();
                                        readProfileID.Read();
                                        String userProfileId = readProfileID.GetString("id");
                                        readProfileID.Close();

                                        MySqlCommand getUseRoleId = new MySqlCommand(getUserRoleIdSql, mySqlConnection);
                                        getUseRoleId.CommandText = getUserRoleIdSql;
                                        getUseRoleId.Parameters.AddWithValue("@roleName", userRole);
                                        MySqlDataReader readRoleId = getUseRoleId.ExecuteReader();
                                        readRoleId.Read();
                                        String userRoleId = readRoleId.GetString("id");
                                        readRoleId.Close();

                                        MySqlCommand saveUserLoginDetails = new MySqlCommand(saveUserLoginSql, mySqlConnection);
                                        saveUserLoginDetails.CommandText = saveUserLoginSql;
                                        saveUserLoginDetails.Parameters.AddWithValue("@emailAddress", email);
                                        saveUserLoginDetails.Parameters.AddWithValue("@password", StringCipher.Encrypt(password, LoginDetails.passwordKey));
                                        saveUserLoginDetails.Parameters.AddWithValue("@createDateTime", dateTime);
                                        saveUserLoginDetails.Parameters.AddWithValue("@updateDateTime", null);
                                        saveUserLoginDetails.Parameters.AddWithValue("@isActive", 1);
                                        saveUserLoginDetails.Parameters.AddWithValue("@isOnline", 0);
                                        saveUserLoginDetails.Parameters.AddWithValue("@user_role_id", userRoleId);
                                        saveUserLoginDetails.Parameters.AddWithValue("@user_profile_id", userProfileId);
                                        saveUserLoginDetails.ExecuteNonQuery();
                                        mySqlConnection.Close();
                                        MessageBox.Show("Librarian Successfully Saved!", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        resetForm();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Passwords do not match", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Account already exists please try with different email id", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid email address", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                }
                else
                {
                    //Reader Selected
                    MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand commandSaveReader = new MySqlCommand(saveUserProfileSql, mySqlConnection);
                    commandSaveReader.CommandText = saveUserProfileSql;
                    commandSaveReader.Parameters.AddWithValue("@generatedID", userId);
                    commandSaveReader.Parameters.AddWithValue("@firstName", fName);
                    commandSaveReader.Parameters.AddWithValue("@lastName", lName);
                    commandSaveReader.Parameters.AddWithValue("@mobileNumber", mobile);
                    commandSaveReader.Parameters.AddWithValue("@landLineNumber", landNumber);
                    commandSaveReader.Parameters.AddWithValue("@permenentAddress", pAddress);
                    commandSaveReader.Parameters.AddWithValue("@residentAddress", rAddress);
                    commandSaveReader.Parameters.AddWithValue("@isResidentSame", isResidenceSame);
                    commandSaveReader.Parameters.AddWithValue("@birthday", birthday);
                    if (imageLoacation != null)
                    {
                        commandSaveReader.Parameters.AddWithValue("@profileImageUrl", images.ToString());
                    }
                    else
                    {
                        commandSaveReader.Parameters.AddWithValue("@profileImageUrl", null);
                    }
                    commandSaveReader.Parameters.AddWithValue("@createDateTime", dateTime);
                    commandSaveReader.Parameters.AddWithValue("@updateDateTime", null);
                    commandSaveReader.Parameters.AddWithValue("@isActive", 1);
                    commandSaveReader.Parameters.AddWithValue("@user_login_history_id", LoginDetails.userLoginHistoryID);

                    MySqlCommand getProfileTypeId = new MySqlCommand(getProfileTypeIdSql, mySqlConnection);
                    getProfileTypeId.CommandText = getProfileTypeIdSql;
                    Console.WriteLine("User Profile Type :"+profileType);
                    Console.WriteLine("Date Time :"+dateTime);
                    getProfileTypeId.Parameters.AddWithValue("profileType", profileType);
                    MySqlDataReader readTypeId = getProfileTypeId.ExecuteReader();
                    readTypeId.Read();
                    
                    commandSaveReader.Parameters.AddWithValue("@user_profile_type_id", readTypeId.GetString("id"));
                    readTypeId.Close();

                    commandSaveReader.ExecuteNonQuery();
                    mySqlConnection.Close();

                    MessageBox.Show("Reader Successfully Saved!", "Register new user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetForm();
                }
            }
                        
        }

        private void resetForm()
        {
            comboBoxProfileType.SelectedIndex = -1;
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxMobile.Text = "";
            textBoxLand.Text = "";
            textBoxPAddress.Text = "";
            textBoxRAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxRePassword.Text = "";
            dateTimePickerBirthday.ResetText();
            Add_New_User_Load(this, null);
        }

        private void Add_New_User_Load(object sender, EventArgs e)
        {
            checkBoxAdmin.Hide();
            panel1.Hide();
            generateID();
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";

        }

        private void checkBoxConfirmAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConfirmAddress.Checked)
            {
                textBoxRAddress.Text = textBoxPAddress.Text;
                isResidenceSame = true;
            }
            else
            {
                textBoxRAddress.Text = "";
                isResidenceSame = false;
            }
            
        }

        private void comboBoxProfileType_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedType = comboBoxProfileType.Text;
            if (selectedType.Equals("Librarian"))
            {
                checkBoxAdmin.Show();
                panel1.Show();
            }
            else
            {
                checkBoxAdmin.Hide();
                panel1.Hide();
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool isValidAccount(String email)
        {
            String loginQuery = "SELECT * FROM user_login WHERE emailAddress = @email";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command = new MySqlCommand(loginQuery, mySqlConnection);
            command.CommandText = loginQuery;
            command.Parameters.AddWithValue("@email", email);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            

            if (mySqlDataReader.HasRows)
            {
                mySqlConnection.Close();
                return false;
            }
            else
            {
                mySqlConnection.Close();
                return true;
            }
            
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_New_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textBoxLand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
