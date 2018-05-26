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
        public Edit_Category()
        {
            InitializeComponent();
            fillCategory();
            //editCategory();
        }

        void fillCategory()
        {
            try
            {
               // textBoxAddCategory.Text = null;
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
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Please check the connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void editCategory() {
           

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
    }
}
