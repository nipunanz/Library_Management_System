using System;
using System.Collections;
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
    public partial class Add_New_Category : Form
    {
        Register_new_books rnbinstance;
        public Add_New_Category(Register_new_books rnb)
        {
            this.rnbinstance = rnb;
            InitializeComponent();
        }


        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            if (textBoxAddCategory.Text == "")
            {

                MessageBox.Show(" Invalid Entry ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                DateTime dateTime = DateTime.Now;
                dateTime.ToString("yyyyMMddHHmmss");

                String categoryName = textBoxAddCategory.Text;
                int bookCount = 0;
                int isActive = 1;
                int user_login_id = 1;

                String newBookCategory_SQL = "INSERT INTO book_category (name,bookCount,createDateTime,updateDateTime,isActive,user_login_history_id) VALUES (@name,@bookCount,@createDateTime,@updateDateTime,@isActive,@user_login_history_id)";

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_newBookCatergory = new MySqlCommand(newBookCategory_SQL, mySqlConnection);
                command_newBookCatergory.CommandText = newBookCategory_SQL;
                command_newBookCatergory.Parameters.AddWithValue("@name", categoryName);
                command_newBookCatergory.Parameters.AddWithValue("@bookCount", bookCount);
                command_newBookCatergory.Parameters.AddWithValue("@createDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                command_newBookCatergory.Parameters.AddWithValue("@isActive", isActive);
                command_newBookCatergory.Parameters.AddWithValue("@user_login_history_id", user_login_id);

                command_newBookCatergory.ExecuteNonQuery();

                mySqlConnection.Close();
                DialogResult dialogResult = MessageBox.Show(" Book Catergory Added ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                  textBoxAddCategory.Text = String.Empty ;
                    
                    new Register_new_books().Show();
                    rnbinstance.Hide();
                    this.Dispose();
                    
                }
            }
        }
    }
}