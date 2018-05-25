using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
