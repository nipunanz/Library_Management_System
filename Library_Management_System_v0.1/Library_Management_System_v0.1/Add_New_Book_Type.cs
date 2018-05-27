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
    public partial class Add_New_Book_Type : Form
    {
        Register_new_books rnbinstance;
        public Add_New_Book_Type(Register_new_books rnb)
        {
            InitializeComponent();
            this.rnbinstance = rnb;
        }

        private void buttonSaveBookType_Click(object sender, EventArgs e)
        {
            String newBookType = textBoxAddBookType.Text;
            if (textBoxAddBookType.Text == "")
            {

                MessageBox.Show(" Invalid Entry ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                if (isValidBookType(newBookType))
                {
                    String addNewBookTypeQuery = "INSERT INTO book_type (name) VALUES (@name)";

                    MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand newBookTypeCommand = new MySqlCommand(addNewBookTypeQuery, mySqlConnection);
                    newBookTypeCommand.CommandText = addNewBookTypeQuery;
                    newBookTypeCommand.Parameters.AddWithValue("@name", newBookType);
                    newBookTypeCommand.ExecuteNonQuery();
                    mySqlConnection.Close();

                    DialogResult dialogResult = MessageBox.Show("New Book Type Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        textBoxAddBookType.Text = String.Empty;
                        //Register_new_books
                        new Register_new_books().Show();
                        rnbinstance.Hide();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(" Book Type Exist! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
                
        }
        bool isValidBookType(String bookType)
        {
            String loginQuery = "SELECT * FROM book_type WHERE name = @name";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command = new MySqlCommand(loginQuery, mySqlConnection);
            command.CommandText = loginQuery;
            command.Parameters.AddWithValue("@name", bookType);
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
