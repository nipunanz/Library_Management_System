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
    public partial class Add_New_Publisher : Form
    {
        Register_new_books rnbinstance;
        public Add_New_Publisher(Register_new_books rnb)
        {
            InitializeComponent();
            this.rnbinstance = rnb;
        }

        private void buttonSavePublisher_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAddPublisher.Text == "")
                {

                    MessageBox.Show(" Invalid Entry ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    dateTime.ToString("yyyyMMddHHmmss");

                    String publisherName = textBoxAddPublisher.Text;
                    if (isValidPublisher(publisherName))
                    {
                        String publisherDescp = textBoxPublisherDescp.Text;
                        int bookCount = 0;
                        int isActive = 1;
                        int user_login_id = 4;
                        //MySqlConnection connection = DataConnection.getDBConnection();
                        String newAuthor_SQL = "INSERT INTO book_printers (name,description,bookCount,createDateTime,updateDateTime,isActive,user_login_history_id) VALUES (@name,@description,@bookCount,@createDateTime,@updateDateTime,@isActive,@user_login_history_id)";
                        MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                        mySqlConnection.Open();

                        MySqlCommand command_newBookCatergory = new MySqlCommand(newAuthor_SQL, mySqlConnection);
                        command_newBookCatergory.CommandText = newAuthor_SQL;
                        command_newBookCatergory.Parameters.AddWithValue("@name", publisherName);
                        command_newBookCatergory.Parameters.AddWithValue("@description", publisherDescp);
                        command_newBookCatergory.Parameters.AddWithValue("@bookCount", bookCount);
                        command_newBookCatergory.Parameters.AddWithValue("@createDateTime", dateTime);
                        command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                        command_newBookCatergory.Parameters.AddWithValue("@isActive", isActive);
                        command_newBookCatergory.Parameters.AddWithValue("@user_login_history_id", user_login_id);

                        command_newBookCatergory.ExecuteNonQuery();
                        mySqlConnection.Close();

                        DialogResult dialogResult = MessageBox.Show(" Publisher Added ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            textBoxAddPublisher.Text = String.Empty;
                            textBoxPublisherDescp.Text = String.Empty;
                            new Register_new_books().Show();
                            rnbinstance.Hide();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Book Publisher Exist! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool isValidPublisher(String publisherName)
        {
            String loginQuery = "SELECT * FROM book_printers WHERE name = @name";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command = new MySqlCommand(loginQuery, mySqlConnection);
            command.CommandText = loginQuery;
            command.Parameters.AddWithValue("@name", publisherName);
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
    }
}
