﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v0._1
{
    public partial class Return_Books : Form
    {
        public Return_Books()
        {
            InitializeComponent();
        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                String userID = textBoxBookID.Text;
                if (!userID.Equals(""))
                {
                    String loadUserSql = "SELECT * FROM user_profile WHERE generatedID = @generatedID";
                    connection = DataConnection.getDBConnection();
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(loadUserSql, connection);
                    command.CommandText = loadUserSql;
                    command.Parameters.AddWithValue("@generatedID", userID);

                    DataTable dt = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        label3.Text = dt.Rows[0][2].ToString();
                        label4.Text = dt.Rows[0][3].ToString();
                        label6.Text = dt.Rows[0][6].ToString();
                        label9.Text = dt.Rows[0][4].ToString();
                        //label11.Text = dt.Rows[0][9].ToString();
                        DateTime retrievedDate = (DateTime)dt.Rows[0][9];
                        label11.Text = retrievedDate.ToString("dd-MM-yyyy");

                        byte[] image = (byte[])dt.Rows[0][10];
                        MemoryStream ms2 = new MemoryStream(image);
                        pictureBox1.Image = Image.FromStream(ms2);

                        dataAdapter.Dispose();
                    }
                    String loadtable_SQL = "SELECT generatedID, book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                        "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                        "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id";

                    string searchBook = loadtable_SQL + " WHERE book_profile.id in ( SELECT book_profile_id FROM issue_and_return_book WHERE isReturn= false AND issue_and_return_book_batch_id IN (SELECT id FROM issue_and_return_book_batch WHERE user_profile_id=(SELECT id FROM user_profile WHERE generatedID='" + userID + "')))";

                    MySqlCommand cmd_Profile = new MySqlCommand(searchBook, connection);
                    MySqlDataReader DataReader2 = cmd_Profile.ExecuteReader();

                    while (DataReader2.Read())
                    {
                        String id = DataReader2.GetString("generatedID");
                        String name = DataReader2.GetString("name");
                        String isbn = DataReader2.GetString("ISBN");
                        String printYear = DataReader2.GetString("printedYear");
                        String category = DataReader2.GetString("categoryName");
                        String author = DataReader2.GetString("authorName");
                        String type = DataReader2.GetString("bookTypeName");
                        String bookCount = DataReader2.GetString("bookCount");
                        String isActive = DataReader2.GetString("status");
                        String bookPublisher = DataReader2.GetString("bookPublisher");
                        String bookDescription = DataReader2.GetString("bookDescription");
                        String status = "";
                        if (isActive.Equals("True"))
                        {
                            status = "Active";
                        }
                        else
                        {
                            status = "Deactive";
                        }

                        dataGridView1.Rows.Add(id, name, isbn, printYear, category, author, type, bookCount, status, bookPublisher, bookDescription);

                    }
                    DataReader2.Close();

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the user ID", "Return Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                connection.Close();
            }
            

        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            label12.Text = dateTime.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSelectedRow = dataGridView1.CurrentRow.Selected;
                if (isSelectedRow)
                {
                    markAsReturnOk(dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBoxBookID.Text);
                    MessageBox.Show("Successfully marked as returned", "Return Books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.RowCount = 0;
                    buttonUserSearch_Click(this, null);
                }
                else
                {
                    MessageBox.Show("Please select a book", "Selection Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void markAsReturnOk(string bookID, string userID)
        {
            MySqlConnection mySqlConnection2 = null;
            try
            {
                mySqlConnection2 = DataConnection.getDBConnection();
                mySqlConnection2.Open();

                String searchBook = "SELECT id FROM issue_and_return_book WHERE book_profile_id=(SELECT id FROM  book_profile WHERE generatedID='" + bookID + "') AND isReturn=0 AND issue_and_return_book_batch_id IN (SELECT id FROM issue_and_return_book_batch WHERE user_profile_id=(SELECT id FROM user_profile WHERE generatedID='" + userID + "'))";

                MySqlCommand cmd = new MySqlCommand(searchBook, mySqlConnection2);
                MySqlDataReader dr = cmd.ExecuteReader();

                DateTime dateTime = DateTime.Now;
                dateTime.ToString("yyyyMMddHHmmss");

                if (dr.Read())
                {
                    String id = dr.GetString("id");
                    dr.Close();
                    String updateReturn = "UPDATE issue_and_return_book SET isReturn=@isReturn,returnDateTime=@returnDateTime WHERE id=" + id;
                    MySqlCommand cmd2 = new MySqlCommand(updateReturn, mySqlConnection2);
                    cmd2.CommandText = updateReturn;
                    cmd2.Parameters.AddWithValue("@isReturn", 1);
                    cmd2.Parameters.AddWithValue("@returnDateTime", dateTime);
                    int row = cmd2.ExecuteNonQuery();
                }

                String updateBookBatchReturn = "UPDATE issue_and_return_book_batch SET isReturn = @isReturn WHERE issue_and_return_book_batch.id IN (SELECT issue_and_return_book_batch_id FROM issue_and_return_book WHERE book_profile_id = (SELECT id FROM book_profile WHERE generatedID = '" + bookID + "'))";

                MySqlCommand cmd3 = new MySqlCommand(updateBookBatchReturn, mySqlConnection2);
                cmd3.CommandText = updateBookBatchReturn;
                cmd3.Parameters.AddWithValue("@isReturn", 1);
                cmd3.ExecuteNonQuery();

                mySqlConnection2.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                mySqlConnection2.Close();
            }
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
           
            this.Hide();


        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxBookID_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxBookID.Text == String.Empty)
            {

                label3.Text = "";
                label4.Text = "";
                label6.Text = "";
                label9.Text = "";
                label11.Text = "";
                pictureBox1.Image = Properties.Resources.blank;

            }
        }

        private void textBoxBookID_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = null;

            try
            {
                String selectGeneratedID_SQL = "SELECT generatedID from user_profile WHERE generatedID LIKE @id ";
                connection = DataConnection.getDBConnection();
                connection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                MySqlDataReader mySqlDataReader;

                MySqlCommand cmd_SELECTID = new MySqlCommand(selectGeneratedID_SQL, connection);

                cmd_SELECTID.Parameters.Add(new MySqlParameter("@id", "%" + textBoxBookID.Text + "%"));

                cmd_SELECTID.ExecuteNonQuery();
                mySqlDataReader = cmd_SELECTID.ExecuteReader();

                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

                while (mySqlDataReader.Read())
                {

                    auto.Add(mySqlDataReader.GetString(0));

                }

                textBoxBookID.AutoCompleteCustomSource = auto;

                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
