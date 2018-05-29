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
    public partial class Manage_Books : Form
    {
        public Manage_Books()
        {
            InitializeComponent();
            loadTableData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        void loadTableData() {

            String loadtable_SQL = "SELECT book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlDataReader DataReader;
            DataReader = cmd_Profile.ExecuteReader();

            while (DataReader.Read()) {
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
                else {
                    status = "Deactive";
                }

                dataGridView1.Rows.Add(id,name,isbn,printYear,category,author,type, bookCount,status, bookPublisher, bookDescription);

            }

            mySqlConnection.Close();

        }

        private void Manage_Books_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBookID_KeyUp(object sender, KeyEventArgs e)
        {
            String searchVal = "";
            dataGridView1.RowCount = 0;
            String loadtable_SQL = "SELECT book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                 "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                 "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id WHERE generatedID like @generatedID";
            String userRole = LoginDetails.userRole;

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();

            MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
            cmd_Profile.CommandText = loadtable_SQL;
            cmd_Profile.Parameters.AddWithValue("@generatedID", "%"+searchVal+"%");
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

        private void textBoxBookName_KeyUp(object sender, KeyEventArgs e)
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

        private void buttonActivateDeactivate_Click(object sender, EventArgs e)
        {
            String currectBookName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String currectBookISBN = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String currentStatus = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //Console.WriteLine("Selected Row :"+currectId+" Status :"+currentStatus);
            if (currentStatus.Equals("Active"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Deactivate this book", "Manage Books", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    String deactivateUser = "UPDATE book_batch_profile SET isActive = 0 WHERE name = @currectBookName AND ISBN = @currectBookISBN";
                    MySqlConnection sqlConnection = DataConnection.getDBConnection();
                    sqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(deactivateUser, sqlConnection);
                    mySqlCommand.CommandText = deactivateUser;
                    mySqlCommand.Parameters.AddWithValue("@currectBookName", currectBookName);
                    mySqlCommand.Parameters.AddWithValue("@currectBookISBN", currectBookISBN);
                    mySqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Successfully Deactivated!", "Manage books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Activate this book", "Register new user", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    String deactivateUser = "UPDATE book_batch_profile SET isActive = 1 WHERE name = @currectBookName AND ISBN = @currectBookISBN";
                    MySqlConnection sqlConnection = DataConnection.getDBConnection();
                    sqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(deactivateUser, sqlConnection);
                    mySqlCommand.CommandText = deactivateUser;
                    mySqlCommand.Parameters.AddWithValue("@currectBookName", currectBookName);
                    mySqlCommand.Parameters.AddWithValue("@currectBookISBN", currectBookISBN);
                    mySqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Successfully Activated!", "Manage books", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            loadTableData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

            comboControl.bookID = id;
            comboControl.bookName = name;
            comboControl.ISBN = isbn;
            comboControl.printYear = printYear;
            comboControl.descrip = bookDescription;

            Register_new_books edit_book = new Register_new_books(category, author, bookPublisher, type);
            edit_book.Show();
            this.Hide();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
