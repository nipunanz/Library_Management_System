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
            fillBookNames();
            fillComboType();
            fillComboCategory();
            fillComboAuthor();
            fillComboPublisher();
            buttonUpdateBook.Hide();

            if (checkBoxIsNewBook.Checked)
            {
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel1.Enabled = true;
                comboBoxSelectBook.Enabled = false;
            }
            else
            {
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel1.Enabled = true;
                comboBoxSelectBook.Enabled = true;
            }
            
            labelBookID.Text = comboControl.bookID;
            textBoxBookName.Text = comboControl.bookName;
            textBoxISBN.Text = comboControl.ISBN;
            textBoxPrintedYear.Text = comboControl.printYear;
            textBoxBookDescription.Text = comboControl.descrip;

            comboBoxCategory.SelectedItem = comboControl.category;
            comboBoxBookAuthor.SelectedItem = comboControl.author;
            comboBoxBookType.SelectedItem = comboControl.type;
            comboBoxBookPublisher.SelectedItem = comboControl.publisher;
            comboBoxSelectBook.SelectedItem = comboControl.selectedBook;


            generateID();
        }

        public Register_new_books(String category, String author, String publisher, String bookType)
        {
            InitializeComponent();
            fillComboType();
            fillComboCategory();
            fillComboAuthor();
            fillComboPublisher();
            buttonSaveBook.Hide();
            label1.Text = "Edit Book";
            comboBoxBookPublisher.SelectedItem = publisher;
            panel1.Hide();
            comboBoxBookAuthor.SelectedItem = author;
            comboBoxCategory.SelectedItem = category;

            labelBookID.Text = comboControl.bookID;
            textBoxBookName.Text = comboControl.bookName;
            textBoxISBN.Text = comboControl.ISBN;
            textBoxPrintedYear.Text = comboControl.printYear;
            textBoxBookDescription.Text = comboControl.descrip;
        }

        void fillBookNames()
        {
            MySqlConnection  mySqlConnection = null;
            try
            {
                String getBookList = "SELECT name, ISBN FROM book_batch_profile";
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(getBookList, mySqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxSelectBook.Items.Add(reader.GetString("name")+"-"+reader.GetString("ISBN"));
                }

                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please check the connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        void fillComboType()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookType_SQL = "SELECT * FROM book_type";
                mySqlConnection = DataConnection.getDBConnection();
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
        void fillComboCategory()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
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
        void fillComboAuthor()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookAuthor_SQL = "SELECT * FROM book_author";
                mySqlConnection = DataConnection.getDBConnection();

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
        void fillComboPublisher()
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookPublisher_SQL = "SELECT * FROM book_printers";
                mySqlConnection = DataConnection.getDBConnection();

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
        void generateID()
        {
            MySqlConnection mySqlConnection = null;
            try
            {

                DateTime dateObj = DateTime.Now; //Gets the current DATE/TIME

                String date = dateObj.Day.ToString("dd");//Gets the current DAY
                String month = dateObj.Month.ToString("MM");//Gets the current MONTH
                String year = dateObj.Year.ToString("yyyy");//Gets the current YEAR
                String searchDateFormat = year + "-" + month + "-" + date;//Format the date as per SQL Format

                mySqlConnection = DataConnection.getDBConnection();
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
            catch (MySqlException)
            {

                MessageBox.Show("Please check the connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                mySqlConnection.Close();
            }

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

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
            }
            
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

            if (comboBoxCategory.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.category = comboBoxCategory.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
            }
            
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
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxCategory.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();

            }


            //MessageBox.Show(comboControl.bookName);
            new Add_New_Publisher(rnb).Show();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
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
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxCategory.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
            }
            
            new Add_New_Book_Type(rnb).Show();
        }

        private void comboBoxBookType_Click(object sender, EventArgs e)
        {
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


            if (bookName.Equals("") || bookISBN.Equals("") || bookPYear.Equals(""))
            {

                MessageBox.Show(" Invalid Entry ", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MySqlConnection mySqlConnection = null;
                try
                {

                    Object bookC = selectBCategory(comboBoxCategory.SelectedItem.ToString());
                    Object bookA = selectBAuthor(comboBoxBookAuthor.SelectedItem.ToString());
                    Object bookP = selectBPublisher(comboBoxBookPublisher.SelectedItem.ToString());
                    Object bookT = selectBtype(comboBoxBookType.SelectedItem.ToString());

                    //MessageBox.Show(bookC.ToString() + bookA.ToString() + bookP.ToString() + bookT.ToString());

                    DateTime dateTime = DateTime.Now;
                    dateTime.ToString("yyyyMMddHHmmss");

                    int bookCount = 1;
                    int isActive = 1;
                    //int user_login_id = 1;

                    String newBook_SQL = "INSERT INTO book_batch_profile (name,ISBN,printedYear,description,bookCount,createDateTime,updateDateTime,isActive,book_author_id,book_category_id) VALUES (@name,@ISBN,@printedYear,@description,@bookCount,@createDateTime,@updateDateTime,@isActive,@book_author_id,@book_category_id)";

                    mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();

                    if (!checkBoxIsNewBook.Checked)
                    {
                        String selectedBook = comboBoxSelectBook.SelectedItem.ToString();
                        String[] booknameAndIsbn = selectedBook.Split('-');

                        int currentBookCount = int.Parse(selectBatchBookCount(booknameAndIsbn[0], booknameAndIsbn[1]).ToString());
                        int newBookCount = currentBookCount + 1;
                        updateBookCount(booknameAndIsbn[0], booknameAndIsbn[1], newBookCount);
                    }
                    else
                    {
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

                        command_newBookCatergory.ExecuteNonQuery();//Execute insert query to book_batch_profile

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

                        command_InsertBookProfile.ExecuteNonQuery(); //Execute query to insert into book_profile

                        DialogResult dialogResult = MessageBox.Show(" Book Successfully Registered ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    mySqlConnection.Close();


                    /**Update Author Book Count**/
                    int bookAuthorID = int.Parse(bookA.ToString());
                    int bookAuthorCount = int.Parse(selectAuthorBookCount(bookAuthorID).ToString());
                    bookAuthorCount = (bookAuthorCount + 1);//increase book count
                    updateAuthorBookCount(bookAuthorID, bookAuthorCount);//update the Author Book Count

                    /**Update Category Book Count**/
                    int bookCategoryID = int.Parse(bookC.ToString());
                    int bookCategoryCount = int.Parse(selectCategoryBookCount(bookCategoryID).ToString());
                    bookCategoryCount = (bookCategoryCount + 1);
                    updateCategoryBookCount(bookCategoryID, bookCategoryCount);

                    /**Update Printer Book Count**/
                    int bookPrinterID = int.Parse(bookP.ToString());
                    int bookPrinterCount = int.Parse(selectPrinterBoookCount(bookPrinterID).ToString());
                    bookPrinterCount = (bookPrinterCount + 1);
                    updatePrinterBookCount(bookPrinterID, bookPrinterCount);


                    resetCurrent();
                    

                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(" Please check Category, Author, Publisher, Type selections. ", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }

            }

        }
        Object selectBtype(String bookType) 
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookType_SQL = "SELECT id FROM book_type WHERE name = @name ";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_newBookType = new MySqlCommand(selectBookType_SQL, mySqlConnection);

                command_newBookType.CommandText = selectBookType_SQL;
                command_newBookType.Parameters.AddWithValue("@name", bookType);
                Object sqlResult = command_newBookType.ExecuteScalar();

                // MessageBox.Show(sqlResult.ToString());
                mySqlConnection.Close();
                return sqlResult;
            }
            catch (MySqlException) {
                throw;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
        Object selectBCategory(String bookCategory)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookCategory_SQL = "SELECT id FROM book_category WHERE name = @name ";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_newBookCategory = new MySqlCommand(selectBookCategory_SQL, mySqlConnection);

                command_newBookCategory.CommandText = selectBookCategory_SQL;
                command_newBookCategory.Parameters.AddWithValue("@name", bookCategory);
                Object sqlResult = command_newBookCategory.ExecuteScalar();

                // MessageBox.Show(sqlResult.ToString());
                mySqlConnection.Close();

                return sqlResult;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }
        Object selectBAuthor(String bookAuthor)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookAuthor_SQL = "SELECT id FROM book_author WHERE name = @name ";
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_newBookAuthor = new MySqlCommand(selectBookAuthor_SQL, mySqlConnection);
                command_newBookAuthor.CommandText = selectBookAuthor_SQL;
                command_newBookAuthor.Parameters.AddWithValue("@name", bookAuthor);
                Object sqlResult = command_newBookAuthor.ExecuteScalar();
                // MessageBox.Show(sqlResult.ToString());
                mySqlConnection.Close();
                return sqlResult;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }

        }
        Object selectBPublisher(String bookPublisher)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectBookPublisher_SQL = "SELECT id FROM book_printers WHERE name = @name ";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_newBookPublisher = new MySqlCommand(selectBookPublisher_SQL, mySqlConnection);

                command_newBookPublisher.CommandText = selectBookPublisher_SQL;
                command_newBookPublisher.Parameters.AddWithValue("@name", bookPublisher);
                Object sqlResult = command_newBookPublisher.ExecuteScalar();

                // MessageBox.Show(sqlResult.ToString());
                mySqlConnection.Close();

                return sqlResult;
            }
            catch
            {
                throw;

            }
            finally {
                mySqlConnection.Close();
            }
        }

        private void comboBoxBookType_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxPrintedYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        Object selectBatchBookCount(String bookName, String isbn)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectCurrentBookCountAuthor_SQL = "SELECT bookCount FROM book_batch_profile WHERE name=@bookname AND ISBN=@isbn";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_selectCurrentBookCountAuthor = new MySqlCommand(selectCurrentBookCountAuthor_SQL, mySqlConnection);
                command_selectCurrentBookCountAuthor.CommandText = selectCurrentBookCountAuthor_SQL;
                command_selectCurrentBookCountAuthor.Parameters.AddWithValue("@bookname", bookName);
                command_selectCurrentBookCountAuthor.Parameters.AddWithValue("@isbn", isbn);
                Object sqlResult = command_selectCurrentBookCountAuthor.ExecuteScalar();

                mySqlConnection.Close();

                return sqlResult;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }


        /**Select current author book count and update the current book count**/
        Object selectAuthorBookCount(int bookAuthorID)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectCurrentBookCountAuthor_SQL = "SELECT bookCount FROM book_author WHERE id=@bookid";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_selectCurrentBookCountAuthor = new MySqlCommand(selectCurrentBookCountAuthor_SQL, mySqlConnection);
                command_selectCurrentBookCountAuthor.CommandText = selectCurrentBookCountAuthor_SQL;
                command_selectCurrentBookCountAuthor.Parameters.AddWithValue("@bookid", bookAuthorID);
                Object sqlResult = command_selectCurrentBookCountAuthor.ExecuteScalar();

                mySqlConnection.Close();

                return sqlResult;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }

        int updateBookCount(String bookName, String isbn, int bookCount)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String updateBookCountAuthor_SQL = "UPDATE book_batch_profile SET bookCount=@bookCount WHERE name=@name AND ISBN=@isbn";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_updateCurrentBookCountAuthor = new MySqlCommand(updateBookCountAuthor_SQL, mySqlConnection);

                command_updateCurrentBookCountAuthor.CommandText = updateBookCountAuthor_SQL;
                command_updateCurrentBookCountAuthor.Parameters.AddWithValue("@name", bookName);
                command_updateCurrentBookCountAuthor.Parameters.AddWithValue("@isbn", isbn);
                command_updateCurrentBookCountAuthor.Parameters.AddWithValue("@bookCount", bookCount);
                int row = command_updateCurrentBookCountAuthor.ExecuteNonQuery();
                
                mySqlConnection.Close();

                return row;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        int updateAuthorBookCount(int bookAuthorID, int bookAuthorCount)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String updateBookCountAuthor_SQL = "UPDATE book_author SET bookCount= @bookCount WHERE id=@id";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_updateCurrentBookCountAuthor = new MySqlCommand(updateBookCountAuthor_SQL, mySqlConnection);

                command_updateCurrentBookCountAuthor.CommandText = updateBookCountAuthor_SQL;
                command_updateCurrentBookCountAuthor.Parameters.AddWithValue("@id", bookAuthorID);
                command_updateCurrentBookCountAuthor.Parameters.AddWithValue("@bookCount", bookAuthorCount);
                int row = command_updateCurrentBookCountAuthor.ExecuteNonQuery();


                mySqlConnection.Close();

                return row;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }


        /**Select current category book count and update the current book count **/
        Object selectCategoryBookCount(int bookCategoryID)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectCurrentBookCountCategory_SQL = "SELECT bookCount FROM book_category WHERE id=@bookid";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_selectCurrentBookCountCategory = new MySqlCommand(selectCurrentBookCountCategory_SQL, mySqlConnection);
                command_selectCurrentBookCountCategory.CommandText = selectCurrentBookCountCategory_SQL;
                command_selectCurrentBookCountCategory.Parameters.AddWithValue("@bookid", bookCategoryID);
                Object sqlResult = command_selectCurrentBookCountCategory.ExecuteScalar();

                mySqlConnection.Close();

                return sqlResult;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }
        int updateCategoryBookCount(int bookCategoryID, int bookCategoryCount)
        {
            MySqlConnection mySqlConnection = null;
            try
            {

                String updateBookCountCategory_SQL = "UPDATE book_category SET bookCount= @bookCount WHERE id=@id";
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_updateCurrentBookCountCategory = new MySqlCommand(updateBookCountCategory_SQL, mySqlConnection);

                command_updateCurrentBookCountCategory.CommandText = updateBookCountCategory_SQL;
                command_updateCurrentBookCountCategory.Parameters.AddWithValue("@id", bookCategoryID);
                command_updateCurrentBookCountCategory.Parameters.AddWithValue("@bookCount", bookCategoryCount);
                int row = command_updateCurrentBookCountCategory.ExecuteNonQuery();


                mySqlConnection.Close();

                return row;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }


        /**Select current book printers count and update the current book printer**/
        Object selectPrinterBoookCount(int bookPrinterID)
        { 
            MySqlConnection mySqlConnection = null;
            try
            {
                String selectCurrentPrinterCount_SQL = "SELECT bookCount FROM book_printers WHERE id=@bookid";

                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_selectCurrentPrinterCount = new MySqlCommand(selectCurrentPrinterCount_SQL, mySqlConnection);
                command_selectCurrentPrinterCount.CommandText = selectCurrentPrinterCount_SQL;
                command_selectCurrentPrinterCount.Parameters.AddWithValue("@bookid", bookPrinterID);
                Object sqlResult = command_selectCurrentPrinterCount.ExecuteScalar();

                mySqlConnection.Close();

                return sqlResult;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }
        }
        int updatePrinterBookCount(int bookPrinterID, int bookPrinterCount)
        {
            MySqlConnection mySqlConnection = null;

            try
            {
                String updateBookCountPrinter_SQL = "UPDATE book_printers SET bookCount= @bookCount WHERE id=@id";
                mySqlConnection = DataConnection.getDBConnection();
                mySqlConnection.Open();
                MySqlCommand command_updateCurrentBookCountPrinter = new MySqlCommand(updateBookCountPrinter_SQL, mySqlConnection);

                command_updateCurrentBookCountPrinter.CommandText = updateBookCountPrinter_SQL;
                command_updateCurrentBookCountPrinter.Parameters.AddWithValue("@id", bookPrinterID);
                command_updateCurrentBookCountPrinter.Parameters.AddWithValue("@bookCount", bookPrinterCount);
                int row = command_updateCurrentBookCountPrinter.ExecuteNonQuery();


                mySqlConnection.Close();

                return row;

            }
            catch (MySqlException)
            {
                throw;
            }
            finally {
                mySqlConnection.Close();
            }

        }

        private void resetCurrent()
        {
            generateID();

            textBoxBookName.Text = "";
            textBoxISBN.Text = "";
            textBoxPrintedYear.Text = "";
            textBoxBookDescription.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            comboBoxBookAuthor.SelectedIndex = -1;
            comboBoxBookPublisher.SelectedIndex = -1;
            comboBoxBookType.SelectedIndex = -1;


        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;

            new Edit_Category(rnb).Show();
        }

        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;

            new Edit_Author(rnb).Show();
        }

        private void buttonEditPublisher_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxCategory.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();

            }

            new Edit_Publisher(rnb).Show();
        }

        private void buttonEditType_Click(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxCategory.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
            }

            new Edit_Book_Type(rnb).Show();
        }

        private void Register_new_books_FormClosed(object sender, FormClosedEventArgs e)
        {
            comboControl.bookID = "";
            comboControl.bookName = "";
            comboControl.ISBN = "";
            comboControl.printYear = "";
            comboControl.descrip = "";
        }
        //Update Button
        private void buttonUpdateBook_Click(object sender, EventArgs e)
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
                    //Object bookP = selectBPublisher(comboBoxBookPublisher.SelectedItem.ToString());
                    //Object bookT = selectBtype(comboBoxBookType.SelectedItem.ToString());

                    //MessageBox.Show(bookC.ToString() + bookA.ToString() + bookP.ToString() + bookT.ToString());

                    DateTime dateTime = DateTime.Now;
                    dateTime.ToString("yyyyMMddHHmmss");

                    int bookCount = 1;
                    int isActive = 1;
                    //int user_login_id = 1;

                    String newBook_SQL = "UPDATE book_batch_profile SET name=@name, ISBN=@ISBN, printedYear=@printedYear, description=@description, updateDateTime=@updateDateTime, book_author_id=@book_author_id, book_category_id=@book_category_id WHERE id = @batchId";

                    MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand command_newBookCatergory = new MySqlCommand(newBook_SQL, mySqlConnection);
                    command_newBookCatergory.CommandText = newBook_SQL;
                    command_newBookCatergory.Parameters.AddWithValue("@name", bookName);
                    command_newBookCatergory.Parameters.AddWithValue("@ISBN", bookISBN);
                    command_newBookCatergory.Parameters.AddWithValue("@printedYear", bookPYear);
                    command_newBookCatergory.Parameters.AddWithValue("@description", bookDescrip);
                    command_newBookCatergory.Parameters.AddWithValue("@updateDateTime", dateTime);
                    //command_newBookCatergory.Parameters.AddWithValue("@book_type_id", bookT);
                    command_newBookCatergory.Parameters.AddWithValue("@book_author_id", bookA);
                    command_newBookCatergory.Parameters.AddWithValue("@book_category_id", bookC);
                    command_newBookCatergory.Parameters.AddWithValue("@batchId", comboControl.bookID);
                    //command_newBookCatergory.Parameters.AddWithValue("@book_printers_id", bookP);

                    command_newBookCatergory.ExecuteNonQuery();//Execute insert query to book_batch_profile

                    //String date = dateTime.Day.ToString("dd");//Gets the current DAY
                    //String month = dateTime.Month.ToString("MM");//Gets the current MONTH
                    //String year = dateTime.Year.ToString("yyyy");//Gets the current YEAR
                    //String searchDateFormat = year + "-" + month + "-" + date;//Format the date as per SQL Format

                    // String searchDailyCount_SQL = "SELECT id FROM book_batch_profile WHERE createDateTime = @date";
                    // MySqlCommand command_searchID = new MySqlCommand(searchDailyCount_SQL, mySqlConnection);
                    // command_newBookCatergory.CommandText = searchDailyCount_SQL;
                    // command_newBookCatergory.Parameters.AddWithValue("@date", dateTime.ToString("yyyyMMddHHmmss"));
                    // Object book_batch_profile_id = command_newBookCatergory.ExecuteScalar();

                    // String insertBookProfile_SQL = "INSERT INTO book_profile (generatedID,book_batch_profile_id,book_printers_id,book_type_id) VALUES (@generatedID, @book_batch_profile_id,@book_printers_id,@book_type_id)";
                    // MySqlCommand command_InsertBookProfile = new MySqlCommand(insertBookProfile_SQL, mySqlConnection);
                    // command_InsertBookProfile.Parameters.AddWithValue("@generatedID", bookID);
                    // command_InsertBookProfile.Parameters.AddWithValue("@book_batch_profile_id", book_batch_profile_id.ToString());
                    // command_InsertBookProfile.Parameters.AddWithValue("@book_printers_id", bookP);
                    // command_InsertBookProfile.Parameters.AddWithValue("@book_type_id", bookT);

                    // command_InsertBookProfile.ExecuteNonQuery(); //Execute query to insert into book_profile

                    DialogResult dialogResult = MessageBox.Show(" Book Successfully Updated ! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    mySqlConnection.Close();
                    /**Update Author Book Count**/
                    //int bookAuthorID = int.Parse(bookA.ToString());
                    //int bookAuthorCount = int.Parse(selectAuthorBookCount(bookAuthorID).ToString());
                    //bookAuthorCount = (bookAuthorCount + 1);//increase book count
                    //updateAuthorBookCount(bookAuthorID, bookAuthorCount);//update the Author Book Count

                    /**Update Category Book Count**/
                    // int bookCategoryID = int.Parse(bookC.ToString());
                    //int bookCategoryCount = int.Parse(selectCategoryBookCount(bookCategoryID).ToString());
                    // bookCategoryCount = (bookCategoryCount + 1);
                    // updateCategoryBookCount(bookCategoryID, bookCategoryCount);

                    /**Update Printer Book Count**/
                    // int bookPrinterID = int.Parse(bookP.ToString());
                    // int bookPrinterCount = int.Parse(selectPrinterBoookCount(bookPrinterID).ToString());
                    // bookPrinterCount = (bookPrinterCount + 1);
                    // updatePrinterBookCount(bookPrinterID, bookPrinterCount);


                    new Manage_Books().Show();
                    this.Hide();


                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(" Please check Category, Author selections. ", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAddAuthor_Click_1(object sender, EventArgs e)
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

        private void buttonEditAuthor_Click_1(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;

            new Edit_Author(rnb).Show();
        }

        private void checkBoxIsNewBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsNewBook.Checked)
            {
                label2.Enabled = false;
                comboBoxSelectBook.Enabled = false;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                resetCurrent();
                
            }
            else
            {
                label2.Enabled = true;
                comboBoxSelectBook.Enabled = true;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                resetCurrent();
            }
        }

        private void comboBoxSelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (selectedBook != null)
            {
                String[] booknameAndIsbn = selectedBook.Split('-');
                String loadtable_SQL = "SELECT book_batch_profile.bookCount as bookCount, book_batch_profile.description as bookDescription, book_printers.name as bookPublisher, book_batch_profile.id as batchId, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName, book_batch_profile.isActive as status FROM book_batch_profile " +
                    "INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id " +
                    "INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id WHERE book_batch_profile.ISBN  = '" + booknameAndIsbn[1] + "' AND book_batch_profile.name = '" + booknameAndIsbn[0] + "'";
                try
                {
                    MySqlConnection mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                    MySqlDataReader DataReader;
                    DataReader = cmd_Profile.ExecuteReader();

                    if (DataReader.Read())
                    {
                        String id = DataReader.GetString("batchId");
                        String name = DataReader.GetString("name");
                        String isbn = DataReader.GetString("ISBN");
                        String printYear = DataReader.GetString("printedYear");
                        String category = DataReader.GetString("categoryName");
                        String author = DataReader.GetString("authorName");
                        String type = DataReader.GetString("bookTypeName");
                        String bookPublisher = DataReader.GetString("bookPublisher");
                        String bookDescription = DataReader.GetString("bookDescription");

                        textBoxBookName.Text = name;
                        textBoxISBN.Text = isbn;
                        textBoxPrintedYear.Text = printYear;
                        textBoxBookDescription.Text = bookDescription;
                        comboBoxBookAuthor.SelectedItem = author;
                        comboBoxBookPublisher.SelectedItem = bookPublisher;
                        comboBoxBookType.SelectedItem = type;
                        comboBoxCategory.SelectedItem = category;
                    }
                    panel1.Enabled = true;
                    mySqlConnection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sorry! Something went wrong. server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void buttonEditAuthor_Click_2(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookPublisher.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxCategory.SelectedItem != null)
            {
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();

            }

            new Edit_Author(rnb).Show();
        }

        private void buttonEditCategory_Click_1(object sender, EventArgs e)
        {
            Register_new_books rnb = this;

            comboControl.bookID = labelBookID.Text; ;
            comboControl.bookName = textBoxBookName.Text;
            comboControl.ISBN = textBoxISBN.Text;
            comboControl.printYear = textBoxPrintedYear.Text;
            comboControl.descrip = textBoxBookDescription.Text;
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookAuthor.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();

            }

            new Edit_Category(rnb).Show();
        }

        private void buttonAddCategory_Click_1(object sender, EventArgs e)
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
            
            if (comboBoxBookAuthor.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxBookPublisher.SelectedItem != null)
            {
                comboControl.author = comboBoxBookAuthor.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();

            }


            //MessageBox.Show(comboControl.bookName);
            new Add_New_Category(rnb).Show();
        }

        private void buttonAddAuthor_Click_2(object sender, EventArgs e)
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
            comboControl.selectedBook = comboBoxSelectBook.SelectedItem.ToString();

            if (comboBoxBookPublisher.SelectedItem != null && comboBoxBookType.SelectedItem != null && comboBoxCategory.SelectedItem != null)
            {
                comboControl.publisher = comboBoxBookPublisher.SelectedItem.ToString();
                comboControl.type = comboBoxBookType.SelectedItem.ToString();
                comboControl.category = comboBoxCategory.SelectedItem.ToString();

            }


            //MessageBox.Show(comboControl.bookName);
            new Add_New_Author(rnb).Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
