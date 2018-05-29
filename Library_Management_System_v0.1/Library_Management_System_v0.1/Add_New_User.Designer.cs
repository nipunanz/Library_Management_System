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
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1284, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.BackgroundImage")));
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(1059, 126);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(173, 168);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(1059, 309);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(173, 33);
            this.buttonBrowse.TabIndex = 20;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Visible = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBoxPAddress
            // 
            this.textBoxPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPAddress.Location = new System.Drawing.Point(219, 429);
            this.textBoxPAddress.Multiline = true;
            this.textBoxPAddress.Name = "textBoxPAddress";
            this.textBoxPAddress.Size = new System.Drawing.Size(363, 88);
            this.textBoxPAddress.TabIndex = 31;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobile.Location = new System.Drawing.Point(220, 309);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(363, 28);
            this.textBoxMobile.TabIndex = 29;
            this.textBoxMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMobile_KeyPress);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(219, 249);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(363, 28);
            this.textBoxLastName.TabIndex = 28;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserId.Location = new System.Drawing.Point(215, 128);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(135, 26);
            this.labelUserId.TabIndex = 27;
            this.labelUserId.Text = "UPR222018051";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(220, 189);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(363, 28);
            this.textBoxFirstName.TabIndex = 26;
            // 
            // bookDescription
            // 
            this.bookDescription.AutoSize = true;
            this.bookDescription.BackColor = System.Drawing.Color.Transparent;
            this.bookDescription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookDescription.Location = new System.Drawing.Point(44, 429);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(165, 26);
            this.bookDescription.TabIndex = 25;
            this.bookDescription.Text = "Permanent Address";
            // 
            // printedYear
            // 
            this.printedYear.AutoSize = true;
            this.printedYear.BackColor = System.Drawing.Color.Transparent;
            this.printedYear.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printedYear.Location = new System.Drawing.Point(44, 309);
            this.printedYear.Name = "printedYear";
            this.printedYear.Size = new System.Drawing.Size(131, 26);
            this.printedYear.TabIndex = 24;
            this.printedYear.Text = "Mobile Number";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.BackColor = System.Drawing.Color.Transparent;
            this.isbn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.isbn.Location = new System.Drawing.Point(44, 249);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(94, 26);
            this.isbn.TabIndex = 23;
            this.isbn.Text = "Last Name";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.BackColor = System.Drawing.Color.Transparent;
            this.bookName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookName.Location = new System.Drawing.Point(44, 189);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(97, 26);
            this.bookName.TabIndex = 22;
            this.bookName.Text = "First Name";
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.BackColor = System.Drawing.Color.Transparent;
            this.bookId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookId.Location = new System.Drawing.Point(44, 126);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(67, 26);
            this.bookId.TabIndex = 21;
            this.bookId.Text = "User ID";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLand.Location = new System.Drawing.Point(220, 370);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(363, 28);
            this.textBoxLand.TabIndex = 30;
            this.textBoxLand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLand_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(44, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Land Number";
            // 
            // textBoxRAddress
            // 
            this.textBoxRAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRAddress.Location = new System.Drawing.Point(219, 548);
            this.textBoxRAddress.Multiline = true;
            this.textBoxRAddress.Name = "textBoxRAddress";
            this.textBoxRAddress.Size = new System.Drawing.Size(363, 88);
            this.textBoxRAddress.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(44, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Recidance Address";
            // 
            // checkBoxConfirmAddress
            // 
            this.checkBoxConfirmAddress.AutoSize = true;
            this.checkBoxConfirmAddress.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxConfirmAddress.Font = new System.Drawing.Font("Roboto Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConfirmAddress.Location = new System.Drawing.Point(220, 642);
            this.checkBoxConfirmAddress.Name = "checkBoxConfirmAddress";
            this.checkBoxConfirmAddress.Size = new System.Drawing.Size(184, 23);
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
            this.label5.Location = new System.Drawing.Point(615, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Birthday";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(776, 128);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(247, 22);
            this.dateTimePickerBirthday.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(615, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "User Profile Type";
            // 
            // comboBoxProfileType
            // 
            this.comboBoxProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProfileType.FormattingEnabled = true;
            this.comboBoxProfileType.Location = new System.Drawing.Point(776, 185);
            this.comboBoxProfileType.Name = "comboBoxProfileType";
            this.comboBoxProfileType.Size = new System.Drawing.Size(247, 30);
            this.comboBoxProfileType.TabIndex = 40;
            this.comboBoxProfileType.SelectedValueChanged += new System.EventHandler(this.comboBoxProfileType_SelectedValueChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(252, 67);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 28);
            this.textBoxEmail.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(35, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 41;
            this.label7.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(252, 114);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(308, 28);
            this.textBoxPassword.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(35, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Password";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRePassword.Location = new System.Drawing.Point(252, 162);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.PasswordChar = '*';
            this.textBoxRePassword.Size = new System.Drawing.Size(308, 28);
            this.textBoxRePassword.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(35, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 26);
            this.label9.TabIndex = 45;
            this.label9.Text = "Re-Type Password";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Roboto Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxAdmin.Location = new System.Drawing.Point(778, 232);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(226, 23);
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
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
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
            this.panel1.Location = new System.Drawing.Point(620, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 231);
            this.panel1.TabIndex = 50;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveUser.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveUser.Location = new System.Drawing.Point(1059, 619);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(173, 53);
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
            this.buttonUpdateUser.Location = new System.Drawing.Point(1059, 619);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(173, 53);
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
            this.buttonHome.Location = new System.Drawing.Point(1197, 35);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(64, 58);
            this.buttonHome.TabIndex = 56;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 703);
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