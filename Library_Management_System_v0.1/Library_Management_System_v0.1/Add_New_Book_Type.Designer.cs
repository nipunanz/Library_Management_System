namespace Library_Management_System_v0._1
{
    partial class Add_New_Book_Type
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
            this.buttonSaveBookType = new System.Windows.Forms.Button();
            this.textBoxAddBookType = new System.Windows.Forms.TextBox();
            this.bookTypeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveBookType
            // 
            this.buttonSaveBookType.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveBookType.Location = new System.Drawing.Point(313, 364);
            this.buttonSaveBookType.Name = "buttonSaveBookType";
            this.buttonSaveBookType.Size = new System.Drawing.Size(149, 47);
            this.buttonSaveBookType.TabIndex = 36;
            this.buttonSaveBookType.Text = "Save";
            this.buttonSaveBookType.UseVisualStyleBackColor = true;
            this.buttonSaveBookType.Click += new System.EventHandler(this.buttonSaveBookType_Click);
            // 
            // textBoxAddBookType
            // 
            this.textBoxAddBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddBookType.Location = new System.Drawing.Point(290, 206);
            this.textBoxAddBookType.Name = "textBoxAddBookType";
            this.textBoxAddBookType.Size = new System.Drawing.Size(363, 34);
            this.textBoxAddBookType.TabIndex = 35;
            // 
            // bookTypeName
            // 
            this.bookTypeName.AutoSize = true;
            this.bookTypeName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeName.Location = new System.Drawing.Point(111, 204);
            this.bookTypeName.Name = "bookTypeName";
            this.bookTypeName.Size = new System.Drawing.Size(132, 37);
            this.bookTypeName.TabIndex = 34;
            this.bookTypeName.Text = "Book Type";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 73);
            this.label1.TabIndex = 33;
            this.label1.Text = "Add New Book Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_New_Book_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.buttonSaveBookType);
            this.Controls.Add(this.textBoxAddBookType);
            this.Controls.Add(this.bookTypeName);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Book_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Book_Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveBookType;
        private System.Windows.Forms.TextBox textBoxAddBookType;
        private System.Windows.Forms.Label bookTypeName;
        private System.Windows.Forms.Label label1;
    }
}