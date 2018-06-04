namespace Library_Management_System_v0._1
{
    partial class Add_New_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_User));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPAddress = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.bookDescription = new System.Windows.Forms.Label();
            this.printedYear = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.Label();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxConfirmAddress = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProfileType = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(963, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Image = global::Library_Management_System_v0._1.Properties.Resources.blank;
            this.pictureBoxUser.Location = new System.Drawing.Point(794, 102);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(130, 137);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(794, 251);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(130, 27);
            this.buttonBrowse.TabIndex = 20;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBoxPAddress
            // 
            this.textBoxPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPAddress.Location = new System.Drawing.Point(164, 349);
            this.textBoxPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPAddress.Multiline = true;
            this.textBoxPAddress.Name = "textBoxPAddress";
            this.textBoxPAddress.Size = new System.Drawing.Size(273, 72);
            this.textBoxPAddress.TabIndex = 31;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobile.Location = new System.Drawing.Point(165, 251);
            this.textBoxMobile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(273, 24);
            this.textBoxMobile.TabIndex = 29;
            this.textBoxMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMobile_KeyDown);
            this.textBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMobile_KeyPress);
            this.textBoxMobile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMobile_KeyUp);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(164, 202);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(273, 24);
            this.textBoxLastName.TabIndex = 28;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserId.Location = new System.Drawing.Point(161, 104);
            this.labelUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(109, 21);
            this.labelUserId.TabIndex = 27;
            this.labelUserId.Text = "UPR222018051";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(165, 154);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(273, 24);
            this.textBoxFirstName.TabIndex = 26;
            // 
            // bookDescription
            // 
            this.bookDescription.AutoSize = true;
            this.bookDescription.BackColor = System.Drawing.Color.Transparent;
            this.bookDescription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookDescription.Location = new System.Drawing.Point(33, 349);
            this.bookDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(133, 21);
            this.bookDescription.TabIndex = 25;
            this.bookDescription.Text = "Permanent Address";
            // 
            // printedYear
            // 
            this.printedYear.AutoSize = true;
            this.printedYear.BackColor = System.Drawing.Color.Transparent;
            this.printedYear.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printedYear.Location = new System.Drawing.Point(33, 251);
            this.printedYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printedYear.Name = "printedYear";
            this.printedYear.Size = new System.Drawing.Size(107, 21);
            this.printedYear.TabIndex = 24;
            this.printedYear.Text = "Mobile Number";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.BackColor = System.Drawing.Color.Transparent;
            this.isbn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.isbn.Location = new System.Drawing.Point(33, 202);
            this.isbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(77, 21);
            this.isbn.TabIndex = 23;
            this.isbn.Text = "Last Name";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.BackColor = System.Drawing.Color.Transparent;
            this.bookName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookName.Location = new System.Drawing.Point(33, 154);
            this.bookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(79, 21);
            this.bookName.TabIndex = 22;
            this.bookName.Text = "First Name";
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.BackColor = System.Drawing.Color.Transparent;
            this.bookId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookId.Location = new System.Drawing.Point(33, 102);
            this.bookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(55, 21);
            this.bookId.TabIndex = 21;
            this.bookId.Text = "User ID";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLand.Location = new System.Drawing.Point(165, 301);
            this.textBoxLand.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(273, 24);
            this.textBoxLand.TabIndex = 30;
            this.textBoxLand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLand_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Land Number";
            // 
            // textBoxRAddress
            // 
            this.textBoxRAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRAddress.Location = new System.Drawing.Point(164, 445);
            this.textBoxRAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRAddress.Multiline = true;
            this.textBoxRAddress.Name = "textBoxRAddress";
            this.textBoxRAddress.Size = new System.Drawing.Size(273, 72);
            this.textBoxRAddress.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(33, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Recidance Address";
            // 
            // checkBoxConfirmAddress
            // 
            this.checkBoxConfirmAddress.AutoSize = true;
            this.checkBoxConfirmAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxConfirmAddress.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConfirmAddress.Location = new System.Drawing.Point(164, 522);
            this.checkBoxConfirmAddress.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxConfirmAddress.Name = "checkBoxConfirmAddress";
            this.checkBoxConfirmAddress.Size = new System.Drawing.Size(181, 23);
            this.checkBoxConfirmAddress.TabIndex = 36;
            this.checkBoxConfirmAddress.Text = "Same as permanent address";
            this.checkBoxConfirmAddress.UseVisualStyleBackColor = false;
            this.checkBoxConfirmAddress.CheckedChanged += new System.EventHandler(this.checkBoxConfirmAddress_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(461, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Birthday";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(582, 104);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerBirthday.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(461, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "User Profile Type";
            // 
            // comboBoxProfileType
            // 
            this.comboBoxProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProfileType.FormattingEnabled = true;
            this.comboBoxProfileType.Location = new System.Drawing.Point(582, 150);
            this.comboBoxProfileType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProfileType.Name = "comboBoxProfileType";
            this.comboBoxProfileType.Size = new System.Drawing.Size(186, 25);
            this.comboBoxProfileType.TabIndex = 40;
            this.comboBoxProfileType.SelectedValueChanged += new System.EventHandler(this.comboBoxProfileType_SelectedValueChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(189, 54);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(232, 24);
            this.textBoxEmail.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(26, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(189, 93);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(232, 24);
            this.textBoxPassword.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(26, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRePassword.Location = new System.Drawing.Point(189, 132);
            this.textBoxRePassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.PasswordChar = '*';
            this.textBoxRePassword.Size = new System.Drawing.Size(232, 24);
            this.textBoxRePassword.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(26, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Re-Type Password";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxAdmin.Location = new System.Drawing.Point(582, 188);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(223, 23);
            this.checkBoxAdmin.TabIndex = 48;
            this.checkBoxAdmin.Text = "Make as an Administrative Librarian";
            this.checkBoxAdmin.UseVisualStyleBackColor = false;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Authentication Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxRePassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(465, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 188);
            this.panel1.TabIndex = 50;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveUser.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveUser.Location = new System.Drawing.Point(794, 503);
            this.buttonSaveUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(130, 43);
            this.buttonSaveUser.TabIndex = 47;
            this.buttonSaveUser.Text = "Create User";
            this.buttonSaveUser.UseVisualStyleBackColor = false;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonUpdateUser.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateUser.Location = new System.Drawing.Point(794, 503);
            this.buttonUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(130, 43);
            this.buttonUpdateUser.TabIndex = 51;
            this.buttonUpdateUser.Text = "Update User";
            this.buttonUpdateUser.UseVisualStyleBackColor = false;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Roboto Condensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHome.Location = new System.Drawing.Point(898, 28);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(48, 47);
            this.buttonHome.TabIndex = 56;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.comboBoxProfileType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxConfirmAddress);
            this.Controls.Add(this.textBoxRAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPAddress);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.bookDescription);
            this.Controls.Add(this.printedYear);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_New_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_New_User_FormClosing);
            this.Load += new System.EventHandler(this.Add_New_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxPAddress;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label bookDescription;
        private System.Windows.Forms.Label printedYear;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label bookId;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxConfirmAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProfileType;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonHome;
    }
}