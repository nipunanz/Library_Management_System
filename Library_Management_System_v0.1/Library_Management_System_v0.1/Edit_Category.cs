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
    public partial class Edit_Category : Form
    {
        Register_new_books rnbinstance;
        public Edit_Category(Register_new_books rnb)
        {
            InitializeComponent();
            fillCategory();
            this.rnbinstance = rnb;
            //editCategory();
        }

        void fillCategory()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                // textBoxAddCategory.Text = null;
                String selectBookCategory_SQL = "SELECT * FROM book_category";
                mySqlConnection = DataConnection.getDBConnection();

                mySqlConnection.Open();
                MySqlCommand cmd_bookCategory = new MySqlCommand(selectBookCategory_SQL, mySqlConnection);
                MySqlDataReader DataReaderBookCategory;

                DataReaderBookCategory = cmd_bookCategory.ExecuteReader();
                while (DataReaderBookCategory.Read())
                {
                    String bookCategory = DataReaderBookCategory.GetString("name");
                    comboBoxCategory.Items.Add(bookCategory);
                }

                mySqlConnection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Please check the connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                mySqlConnection.Close();

            }
        }

        void editCategory(String name, String updateName)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String updateCategory_SQL = "UPDATE book_category SET name=@ubookname WHERE name=@bookname";
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_updateCurrentBookCountCategory = new MySqlCommand(updateCategory_SQL, mySqlConnection);
                command_updateCurrentBookCountCategory.CommandText = updateCategory_SQL;
                command_updateCurrentBookCountCategory.Parameters.AddWithValue("@bookname", name);
                command_updateCurrentBookCountCategory.Parameters.AddWithValue("@ubookname", updateName);
                int row = command_updateCurrentBookCountCategory.ExecuteNonQuery();

                mySqlConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show(" Please check connection ", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }

        }



        private void comboBoxCategory_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxCategory_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAddCategory.Text = comboBoxCategory.SelectedItem.ToString();
        }

        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                String name = comboBoxCategory.SelectedItem.ToString();
                String updatedname = textBoxAddCategory.Text;

                editCategory(name, updatedname);
                DialogResult dialogResult = MessageBox.Show(" Update Successful! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    textBoxAddCategory.Text = String.Empty;

                    new Register_new_books().Show();
                    rnbinstance.Hide();
                    this.Dispose();

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(" Invalid Selection ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException)
            {
                MessageBox.Show(" Please check connection ", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            }
        }
    }
}
