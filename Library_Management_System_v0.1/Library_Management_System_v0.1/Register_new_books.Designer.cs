namespace Library_Management_System_v0._1
{
    partial class Register_new_books
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.printedYear = new System.Windows.Forms.Label();
            this.bookDescription = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxPrintedYear = new System.Windows.Forms.TextBox();
            this.textBoxBookDescription = new System.Windows.Forms.TextBox();
            this.bookCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBookAuthor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBookPublisher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBookType = new System.Windows.Forms.ComboBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
            this.buttonEditPublisher = new System.Windows.Forms.Button();
            this.buttonEditType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(965, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.Location = new System.Drawing.Point(32, 115);
            this.bookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(58, 21);
            this.bookId.TabIndex = 1;
            this.bookId.Text = "Book ID";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(32, 167);
            this.bookName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(46, 21);
            this.bookName.TabIndex = 2;
            this.bookName.Text = "Name";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(32, 221);
            this.isbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(42, 21);
            this.isbn.TabIndex = 3;
            this.isbn.Text = "ISBN";
            // 
            // printedYear
            // 
            this.printedYear.AutoSize = true;
            this.printedYear.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printedYear.Location = new System.Drawing.Point(32, 275);
            this.printedYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printedYear.Name = "printedYear";
            this.printedYear.Size = new System.Drawing.Size(87, 21);
            this.printedYear.TabIndex = 4;
            this.printedYear.Text = "Printed Year";
            // 
            // bookDescription
            // 
            this.bookDescription.AutoSize = true;
            this.bookDescription.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDescription.Location = new System.Drawing.Point(32, 326);
            this.bookDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(82, 21);
            this.bookDescription.TabIndex = 5;
            this.bookDescription.Text = "Description";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(145, 167);
            this.textBoxBookName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(273, 24);
            this.textBoxBookName.TabIndex = 6;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID.Location = new System.Drawing.Point(141, 115);
            this.labelBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(97, 20);
            this.labelBookID.TabIndex = 7;
            this.labelBookID.Text = "BPR222018051";
            this.labelBookID.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBN.Location = new System.Drawing.Point(144, 221);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(273, 24);
            this.textBoxISBN.TabIndex = 8;
            // 
            // textBoxPrintedYear
            // 
            this.textBoxPrintedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrintedYear.Location = new System.Drawing.Point(145, 275);
            this.textBoxPrintedYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrintedYear.Name = "textBoxPrintedYear";
            this.textBoxPrintedYear.Size = new System.Drawing.Size(273, 24);
            this.textBoxPrintedYear.TabIndex = 9;
            this.textBoxPrintedYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrintedYear_KeyPress);
            // 
            // textBoxBookDescription
            // 
            this.textBoxBookDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookDescription.Location = new System.Drawing.Point(144, 326);
            this.textBoxBookDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookDescription.Multiline = true;
            this.textBoxBookDescription.Name = "textBoxBookDescription";
            this.textBoxBookDescription.Size = new System.Drawing.Size(273, 194);
            this.textBoxBookDescription.TabIndex = 10;
            // 
            // bookCategory
            // 
            this.bookCategory.AutoSize = true;
            this.bookCategory.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategory.Location = new System.Drawing.Point(461, 115);
            this.bookCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(65, 21);
            this.bookCategory.TabIndex = 11;
            this.bookCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(573, 114);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(203, 25);
            this.comboBoxCategory.TabIndex = 12;
            this.comboBoxCategory.Text = "Select";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author";
            // 
            // comboBoxBookAuthor
            // 
            this.comboBoxBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookAuthor.FormattingEnabled = true;
            this.comboBoxBookAuthor.Location = new System.Drawing.Point(573, 163);
            this.comboBoxBookAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBookAuthor.Name = "comboBoxBookAuthor";
            this.comboBoxBookAuthor.Size = new System.Drawing.Size(203, 25);
            this.comboBoxBookAuthor.Sorted = true;
            this.comboBoxBookAuthor.TabIndex = 14;
            this.comboBoxBookAuthor.Text = "Select";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Publisher";
            // 
            // comboBoxBookPublisher
            // 
            this.comboBoxBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookPublisher.FormattingEnabled = true;
            this.comboBoxBookPublisher.Location = new System.Drawing.Point(573, 221);
            this.comboBoxBookPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBookPublisher.Name = "comboBoxBookPublisher";
            this.comboBoxBookPublisher.Size = new System.Drawing.Size(203, 25);
            this.comboBoxBookPublisher.Sorted = true;
            this.comboBoxBookPublisher.TabIndex = 16;
            this.comboBoxBookPublisher.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type";
            // 
            // comboBoxBookType
            // 
            this.comboBoxBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookType.FormattingEnabled = true;
            this.comboBoxBookType.Location = new System.Drawing.Point(573, 272);
            this.comboBoxBookType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBookType.Name = "comboBoxBookType";
            this.comboBoxBookType.Size = new System.Drawing.Size(203, 25);
            this.comboBoxBookType.Sorted = true;
            this.comboBoxBookType.TabIndex = 18;
            this.comboBoxBookType.Text = "Select";
            this.comboBoxBookType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookType_SelectedIndexChanged);
            this.comboBoxBookType.Click += new System.EventHandler(this.comboBoxBookType_Click_1);
            this.comboBoxBookType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxBookType_MouseClick);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategory.Location = new System.Drawing.Point(784, 112);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(68, 27);
            this.buttonAddCategory.TabIndex = 19;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthor.Location = new System.Drawing.Point(784, 161);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(68, 27);
            this.buttonAddAuthor.TabIndex = 20;
            this.buttonAddAuthor.Text = "Add";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPublisher.Location = new System.Drawing.Point(784, 219);
            this.buttonAddPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(68, 27);
            this.buttonAddPublisher.TabIndex = 21;
            this.buttonAddPublisher.Text = "Add";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAddType
            // 
            this.buttonAddType.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddType.Location = new System.Drawing.Point(784, 270);
            this.buttonAddType.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(68, 27);
            this.buttonAddType.TabIndex = 22;
            this.buttonAddType.Text = "Add";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveBook.Location = new System.Drawing.Point(800, 481);
            this.buttonSaveBook.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(112, 38);
            this.buttonSaveBook.TabIndex = 23;
            this.buttonSaveBook.Text = "Save";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCategory.Location = new System.Drawing.Point(857, 112);
            this.buttonEditCategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(68, 27);
            this.buttonEditCategory.TabIndex = 24;
            this.buttonEditCategory.Text = "Edit";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAuthor.Location = new System.Drawing.Point(857, 161);
            this.buttonEditAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(68, 27);
            this.buttonEditAuthor.TabIndex = 25;
            this.buttonEditAuthor.Text = "Edit";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.buttonEditAuthor_Click);
            // 
            // buttonEditPublisher
            // 
            this.buttonEditPublisher.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPublisher.Location = new System.Drawing.Point(857, 219);
            this.buttonEditPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditPublisher.Name = "buttonEditPublisher";
            this.buttonEditPublisher.Size = new System.Drawing.Size(68, 27);
            this.buttonEditPublisher.TabIndex = 26;
            this.buttonEditPublisher.Text = "Edit";
            this.buttonEditPublisher.UseVisualStyleBackColor = true;
            this.buttonEditPublisher.Click += new System.EventHandler(this.buttonEditPublisher_Click);
            // 
            // buttonEditType
            // 
            this.buttonEditType.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditType.Location = new System.Drawing.Point(857, 270);
            this.buttonEditType.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditType.Name = "buttonEditType";
            this.buttonEditType.Size = new System.Drawing.Size(68, 27);
            this.buttonEditType.TabIndex = 27;
            this.buttonEditType.Text = "Edit";
            this.buttonEditType.UseVisualStyleBackColor = true;
            this.buttonEditType.Click += new System.EventHandler(this.buttonEditType_Click);
            // 
            // Register_new_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.buttonEditType);
            this.Controls.Add(this.buttonEditPublisher);
            this.Controls.Add(this.buttonEditAuthor);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.buttonSaveBook);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.comboBoxBookType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBookPublisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBookAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.textBoxBookDescription);
            this.Controls.Add(this.textBoxPrintedYear);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.bookDescription);
            this.Controls.Add(this.printedYear);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register_new_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Books";
            this.Load += new System.EventHandler(this.Register_new_books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookId;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label printedYear;
        private System.Windows.Forms.Label bookDescription;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxPrintedYear;
        private System.Windows.Forms.TextBox textBoxBookDescription;
        private System.Windows.Forms.Label bookCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBookAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBookPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.Button buttonEditPublisher;
        private System.Windows.Forms.Button buttonEditType;
        public System.Windows.Forms.ComboBox comboBoxBookType;
    }
}