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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
                       
        }

        public Home(String userType)
        {
            InitializeComponent();
            buttonRegNewBook.Hide();
            buttonManageBooks.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            Register_new_books register_New_Books = new Register_new_books();
            register_New_Books.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_New_User add_New_User = new Add_New_User();
            add_New_User.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
        }

        private void buttonManageBooks_Click(object sender, EventArgs e)
        {
            Manage_Books manage_Books = new Manage_Books();
            manage_Books.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return_Books return_Books = new Return_Books();
            return_Books.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Issue_Books issue_Books = new Issue_Books();
            issue_Books.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yyyyMMddHHmmss");
            MySqlConnection mySqlConnection = null;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want Logout from the system?", "Signing Off", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    String logoutUser = "UPDATE user_login_history SET logoutDateTime = @dateTime WHERE id = '" + LoginDetails.userLoginHistoryID + "'";
                    mySqlConnection = DataConnection.getDBConnection();
                    mySqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(logoutUser, mySqlConnection);
                    command.CommandText = logoutUser;
                    command.Parameters.AddWithValue("@dateTime", dateTime);
                    command.ExecuteNonQuery();
                    mySqlConnection.Close();

                    Application.Exit();
                    //this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Something Went Wrong! \n" + ex, "Signing Off", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                finally {
                    mySqlConnection.Close();
                }
            }
            
        }

        private void buttonLogout_MouseEnter(object sender, EventArgs e)
        {
            buttonLogout.BackColor = Color.Transparent;
        }
    }
}
