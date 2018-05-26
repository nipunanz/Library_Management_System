﻿using System;
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

            String searchDailyCount = "SELECT COUNT(id) FROM book_batch_profile WHERE createDateTime LIKE @date";
            MySqlCommand command_newBookCatergory = new MySqlCommand(searchDailyCount, mySqlConnection);
            command_newBookCatergory.CommandText = searchDailyCount;
            command_newBookCatergory.Parameters.AddWithValue("@date", "%" + dateObj.ToString(searchDateFormat) + "%");
            Object sqlResult = command_newBookCatergory.ExecuteScalar();
            int todayCount = int.Parse(sqlResult.ToString());


            labelBookID.Text = "BPR" + dateObj.ToString(date) + dateObj.ToString(year) + dateObj.ToString(month) + (todayCount + 1);
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
            String bookID = labelBookID.Text;

            String bookName = textBoxBookName.Text;

            String bookISBN = textBoxISBN.Text;
            String bookPYear = textBoxPrintedYear.Text;
            String bookDescrip = textBoxBookDescription.Text;


            if (bookName.Equals("") || bookISBN.Equals("") || bookPYear.Equals("") || bookDescrip.Equals(""))
            {


                MessageBox.Show(" Invalid Entry ", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {



                try
                {

                    Object bookC = selectBCategory(comboBoxCategory.SelectedItem.ToString());
                    Object bookA = selectBAuthor(comboBoxBookAuthor.SelectedItem.ToString());
                    Object bookP = selectBPublisher(comboBoxBookPublisher.SelectedItem.ToString());
                    Object bookT = selectBtype(comboBoxBookType.SelectedItem.ToString());



                    //MessageBox.Show(bookC.ToString() + bookA.ToString() + bookP.ToString() + bookT.ToString());

                    DateTime dateTime = DateTime.Now;
                    dateTime.ToString("yyyyMMddHHmmss");

                    int bookCount = 0;
                    int isActive = 1;
                    //int user_login_id = 1;

                    String newBook_SQL = "INSERT INTO book_batch_profile (name,ISBN,printedYear,description,bookCount,createDateTime,updateDateTime,isActive,book_author_id,book_category_id) VALUES (@name,@ISBN,@printedYear,@description,@bookCount,@createDateTime,@updateDateTime,@isActive,@book_author_id,@book_category_id)";

                    MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand command_newBookCatergory = new MySqlCommand(newBook_SQL, mySqlConnection);
                    command_newBookCatergory.CommandText = newBook_SQL;
                    command_newBookCatergory.Parameters.AddWithValue("@name", bookName);
                    command_newBookCatergory.Parameters.AddWithValue("@ISBN", bookISBN);
                    command_newBookCatergory.Parameters.AddWithValue("@printedYear", bookPYear);
                    command_newBookCatergory.Parameters.AddWithValue("@description", bookDescrip);
                    command_newBookCatergory.Parameters.AddWithValue("@bookCount", bookCount);
                    command_newBookCatergory.Parameters.AddWithValue("@createDateTime", dateTime);
                    command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                    command_newBookCatergory.Parameters.AddWithValue("@isActive", isActive);
                    //command_newBookCatergory.Parameters.AddWithValue("@book_type_id", bookT);
                    command_newBookCatergory.Parameters.AddWithValue("@book_author_id", bookA);
                    command_newBookCatergory.Parameters.AddWithValue("@book_category_id", bookC);
                    //command_newBookCatergory.Parameters.AddWithValue("@book_printers_id", bookP);



                    command_newBookCatergory.ExecuteNonQuery();


                    //String date = dateTime.Day.ToString("dd");//Gets the current DAY
                    //String month = dateTime.Month.ToString("MM");//Gets the current MONTH
                    //String year = dateTime.Year.ToString("yyyy");//Gets the current YEAR
                    //String searchDateFormat = year + "-" + month + "-" + date;//Format the date as per SQL Format

                    String searchDailyCount_SQL = "SELECT id FROM book_batch_profile WHERE createDateTime = @date";
                    MySqlCommand command_searchID = new MySqlCommand(searchDailyCount_SQL, mySqlConnection);
                    command_newBookCatergory.CommandText = searchDailyCount_SQL;
                    command_newBookCatergory.Parameters.AddWithValue("@date", dateTime.ToString("yyyyMMddHHmmss"));
                    Object book_batch_profile_id = command_newBookCatergory.ExecuteScalar();

                    String insertBookProfile_SQL = "INSERT INTO book_profile (generatedID,book_batch_profile_id,book_printers_id,book_type_id) VALUES (@generatedID, @book_batch_profile_id,@book_printers_id,@book_type_id)";
                    MySqlCommand command_InsertBookProfile = new MySqlCommand(insertBookProfile_SQL, mySqlConnection);
                    command_InsertBookProfile.Parameters.AddWithValue("@generatedID", bookID);
                    command_InsertBookProfile.Parameters.AddWithValue("@book_batch_profile_id", book_batch_profile_id.ToString());
                    command_InsertBookProfile.Parameters.AddWithValue("@book_printers_id", bookP);
                    command_InsertBookProfile.Parameters.AddWithValue("@book_type_id", bookT);
                    command_InsertBookProfile.ExecuteNonQuery();




                    DialogResult dialogResult = MessageBox.Show(" Book Successfully Registered ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);





                    mySqlConnection.Close();





                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(" Please check Category, Author, Publisher, Type selections. ", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }







        }
        Object selectBtype(String bookType)
        {
            String selectBookType_SQL = "SELECT id FROM book_type WHERE name = @name ";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command_newBookType = new MySqlCommand(selectBookType_SQL, mySqlConnection);

            command_newBookType.CommandText = selectBookType_SQL;
            command_newBookType.Parameters.AddWithValue("@name", bookType);
            Object sqlResult = command_newBookType.ExecuteScalar();

            // MessageBox.Show(sqlResult.ToString());
            mySqlConnection.Close();



            return sqlResult;
        }
        Object selectBCategory(String bookCategory)
        {
            String selectBookCategory_SQL = "SELECT id FROM book_category WHERE name = @name ";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command_newBookCategory = new MySqlCommand(selectBookCategory_SQL, mySqlConnection);

            command_newBookCategory.CommandText = selectBookCategory_SQL;
            command_newBookCategory.Parameters.AddWithValue("@name", bookCategory);
            Object sqlResult = command_newBookCategory.ExecuteScalar();

            // MessageBox.Show(sqlResult.ToString());
            mySqlConnection.Close();



            return sqlResult;
        }
        Object selectBAuthor(String bookAuthor)
        {
            String selectBookAuthor_SQL = "SELECT id FROM book_author WHERE name = @name ";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command_newBookAuthor = new MySqlCommand(selectBookAuthor_SQL, mySqlConnection);

            command_newBookAuthor.CommandText = selectBookAuthor_SQL;
            command_newBookAuthor.Parameters.AddWithValue("@name", bookAuthor);
            Object sqlResult = command_newBookAuthor.ExecuteScalar();

            // MessageBox.Show(sqlResult.ToString());
            mySqlConnection.Close();



            return sqlResult;
        }
        Object selectBPublisher(String bookPublisher)
        {
            String selectBookPublisher_SQL = "SELECT id FROM book_printers WHERE name = @name ";

            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand command_newBookPublisher = new MySqlCommand(selectBookPublisher_SQL, mySqlConnection);

            command_newBookPublisher.CommandText = selectBookPublisher_SQL;
            command_newBookPublisher.Parameters.AddWithValue("@name", bookPublisher);
            Object sqlResult = command_newBookPublisher.ExecuteScalar();

            // MessageBox.Show(sqlResult.ToString());
            mySqlConnection.Close();



            return sqlResult;
        }


        private void comboBoxBookType_Click_1(object sender, EventArgs e)
        {
            // fillComboType();
        }

        private void textBoxPrintedYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!(char.IsDigit(character) && character != 8 && character != 46))
            {
                e.Handled = true;


            }

        }
    }
}
