using System;
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
    public partial class Issue_Books : Form
    {
        public Issue_Books()
        {
            InitializeComponent();
            loadTableData();
        }

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void textBoxBookID_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String userID = textBoxUserId.Text;
                String loadUserSql = "SELECT * FROM user_profile WHERE generatedID = @generatedID";
                MySqlConnection connection = DataConnection.getDBConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand(loadUserSql, connection);
                command.CommandText = loadUserSql;
                command.Parameters.AddWithValue("@generatedID", userID);

                DataTable dt = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dt);

                if (dt.Rows.Count ==0) {
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




                    //(DataReader.GetDateTime("birthday")).ToString("dd-MM-yyyy");

                    // }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error" +ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void loadTableData()
        {

            String loadtable_SQL = "SELECT generatedID, book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlDataReader DataReader;
            DataReader = cmd_Profile.ExecuteReader();

            while (DataReader.Read())
            {
                String id = DataReader.GetString("generatedID");
                String name = DataReader.GetString("name");
                String isbn = DataReader.GetString("ISBN");
                String printYear = DataReader.GetString("printedYear");
                String category = DataReader.GetString("categoryName");
                String author = DataReader.GetString("authorName");
                String type = DataReader.GetString("bookTypeName");
                String bookCount = DataReader.GetString("bookCount");
                String isActive = DataReader.GetString("status");
                String bookPublisher = DataReader.GetString("bookPublisher");
                String bookDescription = DataReader.GetString("bookDescription");
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

            mySqlConnection.Close();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String searchVal = textBox1.Text;
                dataGridView1.RowCount = 0;
                String loadtable_SQL = "SELECT generatedID, book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                     "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                     "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id WHERE generatedID like @generatedID";
                String userRole = LoginDetails.userRole;

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
                cmd_Profile.CommandText = loadtable_SQL;
                cmd_Profile.Parameters.AddWithValue("@generatedID", "%" + searchVal + "%");
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                MySqlDataReader DataReader;
                DataReader = cmd_Profile.ExecuteReader();

                while (DataReader.Read())
                {
                    String id = DataReader.GetString("generatedID");
                    String name = DataReader.GetString("name");
                    String isbn = DataReader.GetString("ISBN");
                    String printYear = DataReader.GetString("printedYear");
                    String category = DataReader.GetString("categoryName");
                    String author = DataReader.GetString("authorName");
                    String type = DataReader.GetString("bookTypeName");
                    String bookCount = DataReader.GetString("bookCount");
                    String isActive = DataReader.GetString("status");
                    String bookPublisher = DataReader.GetString("bookPublisher");
                    String bookDescription = DataReader.GetString("bookDescription");
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
                String loadtable_SQL = "SELECT book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                     "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                     "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id WHERE book_batch_profile.name like @bookName";
                String userRole = LoginDetails.userRole;

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();

                MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
                cmd_Profile.CommandText = loadtable_SQL;
                cmd_Profile.Parameters.AddWithValue("@bookName", "%" + searchVal + "%");
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                MySqlDataReader DataReader;
                DataReader = cmd_Profile.ExecuteReader();

                while (DataReader.Read())
                {
                    String id = DataReader.GetString("batchId");
                    String name = DataReader.GetString("name");
                    String isbn = DataReader.GetString("ISBN");
                    String printYear = DataReader.GetString("printedYear");
                    String category = DataReader.GetString("categoryName");
                    String author = DataReader.GetString("authorName");
                    String type = DataReader.GetString("bookTypeName");
                    String bookCount = DataReader.GetString("bookCount");
                    String isActive = DataReader.GetString("status");
                    String bookPublisher = DataReader.GetString("bookPublisher");
                    String bookDescription = DataReader.GetString("bookDescription");
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

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount != 0)
                {
                    String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    String name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    String isbn = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    String printYear = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    String category = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    String author = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    String type = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    String bookCount = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    String isActive = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    String bookPublisher = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    String bookDescription = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                    dataGridView2.Rows.Add(id, name, isbn, printYear, category, author, type, bookCount, isActive, bookPublisher, bookDescription);
                    dataGridView1.CurrentRow.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowCount = dataGridView2.RowCount;
                //dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                if (rowCount >= 1)
                {
                    String id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    String name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    String isbn = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    String printYear = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    String category = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    String author = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    String type = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                    String bookCount = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                    String isActive = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                    String bookPublisher = dataGridView2.CurrentRow.Cells[9].Value.ToString();
                    String bookDescription = dataGridView2.CurrentRow.Cells[10].Value.ToString();

                    dataGridView1.Rows.Add(id, name, isbn, printYear, category, author, type, bookCount, isActive, bookPublisher, bookDescription);
                    dataGridView2.CurrentRow.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row");
            }


        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yyyyMMddHHmmss");

            try
            {
                String userId = textBoxUserId.Text;
                String returnDate = dateTimePicker1.Text;
                List<String> list = new List<String>();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    list.Add(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                }

                String saveReturnBook = "INSERT INTO issue_and_return_book_batch  (issueDateTime, markedReturnDate, isReturn, remarks, user_profile_id, user_login_history_id) VALUES (@issueDateTime, @markedReturnDate, @isReturn, @remarks, @user_profile_id, @user_login_history_id)";
                String getUserProfileIdSql = "SELECT id FROM user_profile WHERE generatedID = @userId";
                String getUserProfileIdSql2 = "SELECT id FROM issue_and_return_book_batch WHERE issueDateTime = @currentDate";
                String getUserProfileIdSql3 = "SELECT id FROM book_profile WHERE generatedID = @generatedID";
                String saveReturnBook2 = "INSERT INTO issue_and_return_book (returnDateTime, isReturn, remarks, book_profile_id, issue_and_return_book_batch_id) VALUES (@returnDateTime, @isReturn, @remarks, @book_profile_id, @issue_and_return_book_batch_id)";

                MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand cmd_Profile = new MySqlCommand(saveReturnBook, mySqlConnection);
                cmd_Profile.CommandText = saveReturnBook;
                cmd_Profile.Parameters.AddWithValue("@issueDateTime", dateTime);
                cmd_Profile.Parameters.AddWithValue("@markedReturnDate", returnDate);
                cmd_Profile.Parameters.AddWithValue("@isReturn", false);
                cmd_Profile.Parameters.AddWithValue("@remarks", "");

                MySqlCommand getUserProfileId = new MySqlCommand(getUserProfileIdSql, mySqlConnection);
                getUserProfileId.CommandText = getUserProfileIdSql;
                getUserProfileId.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader readProfileID = getUserProfileId.ExecuteReader();
                readProfileID.Read();
                String userProfileId = readProfileID.GetString("id");
                readProfileID.Close();

                cmd_Profile.Parameters.AddWithValue("@user_profile_id", userProfileId);
                cmd_Profile.Parameters.AddWithValue("@user_login_history_id", LoginDetails.userLoginHistoryID);

                cmd_Profile.ExecuteNonQuery();

                MySqlCommand getUserProfileId2 = new MySqlCommand(getUserProfileIdSql2, mySqlConnection);
                getUserProfileId2.CommandText = getUserProfileIdSql2;
                getUserProfileId2.Parameters.AddWithValue("@currentDate", dateTime);
                MySqlDataReader readProfileID2 = getUserProfileId2.ExecuteReader();
                readProfileID2.Read();
                String userProfileId2 = readProfileID2.GetString("id");
                readProfileID2.Close();


                foreach (String s in list)
                {
                    MySqlCommand getUserProfileId3 = new MySqlCommand(getUserProfileIdSql3, mySqlConnection);
                    getUserProfileId3.CommandText = getUserProfileIdSql3;
                    getUserProfileId3.Parameters.AddWithValue("@generatedID", s);
                    MySqlDataReader readProfileID3 = getUserProfileId.ExecuteReader();
                    readProfileID3.Read();
                    String userProfileId3 = readProfileID3.GetString("id");
                    readProfileID3.Close();

                    MySqlCommand mySqlCommand = new MySqlCommand(saveReturnBook2, mySqlConnection);
                    mySqlCommand.CommandText = saveReturnBook2;
                    mySqlCommand.Parameters.AddWithValue("@returnDateTime", null);
                    mySqlCommand.Parameters.AddWithValue("@isReturn", false);
                    mySqlCommand.Parameters.AddWithValue("@remarks", "");
                    mySqlCommand.Parameters.AddWithValue("@book_profile_id", userProfileId3);
                    mySqlCommand.Parameters.AddWithValue("@issue_and_return_book_batch_id", userProfileId2);

                    mySqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Book Successfully Issued!", "Issue books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxUserId_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxUserId.Text == String.Empty) {

                label3.Text ="";
                label4.Text ="";
                label6.Text ="";
                label9.Text ="";
                label11.Text = "";
                pictureBox1.Image = Image.FromFile("../LoadImage/blank.jpg");

            }
        }
    }
}
