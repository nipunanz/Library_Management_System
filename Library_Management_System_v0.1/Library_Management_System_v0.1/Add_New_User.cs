using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library_Management_System_v0._1
{
    public partial class Add_New_User : Form
    {
        public Add_New_User()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        String imageLoacation = "";

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageLoacation = openFile.FileName.ToString();
                pictureBoxUser.ImageLocation = imageLoacation;
            }
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream fileStream = new FileStream(imageLoacation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            images = reader.ReadBytes((int)fileStream.Length);
           
            
        }
    }
}
