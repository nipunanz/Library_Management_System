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

            String loadtable_SQL = "SELECT generatedID, book_batch_profile.name, book_batch_profile.ISBN, book_batch_profile.printedYear, book_category.name as categoryName, book_author.name as authorName, book_type.name as bookTypeName FROM book_batch_profile INNER JOIN book_category on book_batch_profile.book_category_id = book_category.id INNER JOIN book_author on book_author.id = book_batch_profile.book_author_id INNER JOIN book_profile on book_profile.book_batch_profile_id = book_batch_profile.id INNER JOIN book_printers on book_printers.id = book_profile.book_printers_id INNER JOIN book_type on book_type.id = book_profile.book_type_id";
            MySqlConnection mySqlConnection = DataConnection.getDBConnection();
            mySqlConnection.Open();
            MySqlCommand cmd_Profile = new MySqlCommand(loadtable_SQL, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlDataReader DataReader;
            DataReader = cmd_Profile.ExecuteReader();

            while (DataReader.Read()) {
                String id = DataReader.GetString("generatedID");
                String name = DataReader.GetString("name");
               String isbn = DataReader.GetString("ISBN");
                String printYear = DataReader.GetString("printedYear");
               String category = DataReader.GetString("categoryName");
               String author = DataReader.GetString("authorName");
               String type = DataReader.GetString("bookTypeName");


                dataGridView1.Rows.Add(id,name,isbn,printYear,category,author,type);

            }



        }
    }
}
