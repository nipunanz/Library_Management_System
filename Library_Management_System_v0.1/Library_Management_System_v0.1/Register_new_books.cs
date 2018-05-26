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
    public partial class Register_new_books : Form
    {
        public Register_new_books()
        {
            InitializeComponent();
            fillComboType();
            fillComboCategory();
            fillComboAuthor();
            fillComboPublisher();

            labelBookID.Text = comboControl.bookID;
            textBoxBookName.Text = comboControl.bookName;
            textBoxISBN.Text = comboControl.ISBN;
            textBoxPrintedYear.Text = comboControl.printYear;
            textBoxBookDescription.Text = comboControl.descrip;
            generateID();
        }

        void fillComboType()
        {

            String selectBookType_SQL = "SELECT * FROM book_type";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_bookType = new MySqlCommand(selectBookType_SQL, mySqlConnection);
            MySqlDataReader DataReaderBookType;

            DataReaderBookType = cmd_bookType.ExecuteReader();
            while (DataReaderBookType.Read())
            {
                String bookType = DataReaderBookType.GetString("name");
                comboBoxBookType.Items.Add(bookType);

            }

            mySqlConnection.Close();

        }
        void fillComboCategory()
        {

            String selectBookCategory_SQL = "SELECT * FROM book_category";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();

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
        void fillComboAuthor()
        {

            String selectBookAuthor_SQL = "SELECT * FROM book_author";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();

            mySqlConnection.Open();
            MySqlCommand cmd_bookAuthor = new MySqlCommand(selectBookAuthor_SQL, mySqlConnection);
            MySqlDataReader DataReaderBookAuthor;

            DataReaderBookAuthor = cmd_bookAuthor.ExecuteReader();
            while (DataReaderBookAuthor.Read())
            {
                String bookAuthor = DataReaderBookAuthor.GetString("name");
                comboBoxBookAuthor.Items.Add(bookAuthor);

            }

            mySqlConnection.Close();

        }
        void fillComboPublisher()
        {

            String selectBookPublisher_SQL = "SELECT * FROM book_printers";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();

            mySqlConnection.Open();
            MySqlCommand cmd_bookPublisher = new MySqlCommand(selectBookPublisher_SQL, mySqlConnection);
            MySqlDataReader DataReaderBookPublisher;

            DataReaderBookPublisher = cmd_bookPublisher.ExecuteReader();
            while (DataReaderBookPublisher.Read())
            {
                String bookPublisher = DataReaderBookPublisher.GetString("name");
                comboBoxBookPublisher.Items.Add(bookPublisher);

            }

            mySqlConnection.Close();

        }
        void generateID()
        {


            DateTime dateObj = DateTime.Now; //Gets the current DATE/TIME

            String date = dateObj.Day.ToString("dd");//Gets the current DAY
            String month = dateObj.Month.ToString("MM");//Gets the current MONTH
            String year = dateObj.Year.ToString("yyyy");//Gets the current YEAR
            String searchDateFormat = year + "-" + month + "-" + date;//Format the date as per SQL Format

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();

            String searchDailyCount = "SELECT COUNT(id) FROM book_batch_profile WHERE createDateTime LIKE @date ";
            MySqlCommand command_newBookCatergory = new MySqlCommand(searchDailyCount, mySqlConnection);
            command_newBookCatergory.CommandText = searchDailyCount;
            command_newBookCatergory.Parameters.AddWithValue("@date", "%" + dateObj.ToString(searchDateFormat) + "%");
            Object sqlResult = command_newBookCatergory.ExecuteScalar();

            labelBookID.Text = "BPR" + dateObj.ToString(date) + dateObj.ToString(year) + dateObj.ToString(month) + sqlResult.ToString();
            mySqlConnection.Close();

        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_new_books_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            String bookID = labelBookID.Text;
            String bookN = textBoxBookName.Text;
            String isbn = textBoxISBN.Text;
            String pYear = textBoxPrintedYear.Text;
            String descrip = textBoxBookDescription.Text;

            comboControl.bookID = bookID;
            comboControl.bookName = bookN;
            comboControl.ISBN = isbn;
            comboControl.printYear = pYear;
            comboControl.descrip = descrip;

            //MessageBox.Show(comboControl.bookName);
            new Add_New_Category(rnb).Show();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            String bookID = labelBookID.Text;
            String bookN = textBoxBookName.Text;
            String isbn = textBoxISBN.Text;
            String pYear = textBoxPrintedYear.Text;
            String descrip = textBoxBookDescription.Text;

            comboControl.bookID = bookID;
            comboControl.bookName = bookN;
            comboControl.ISBN = isbn;
            comboControl.printYear = pYear;
            comboControl.descrip = descrip;

            //MessageBox.Show(comboControl.bookName);
            new Add_New_Author(rnb).Show();
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            String bookID = labelBookID.Text;
            String bookN = textBoxBookName.Text;
            String isbn = textBoxISBN.Text;
            String pYear = textBoxPrintedYear.Text;
            String descrip = textBoxBookDescription.Text;

            comboControl.bookID = bookID;
            comboControl.bookName = bookN;
            comboControl.ISBN = isbn;
            comboControl.printYear = pYear;
            comboControl.descrip = descrip;

            //MessageBox.Show(comboControl.bookName);
            new Add_New_Publisher(rnb).Show();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;
            new Add_New_Book_Type(rnb).Show();
        }

        private void comboBoxBookType_Click(object sender, EventArgs e)
        {
            //fillComboType();
        }

        private void comboBoxBookType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBookType_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxBookType_Click_1(object sender, EventArgs e)
        {
            // fillComboType();
        }
    }
}
