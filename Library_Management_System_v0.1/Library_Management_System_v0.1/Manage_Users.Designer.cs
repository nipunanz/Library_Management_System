namespace Library_Management_System_v0._1
{
    partial class Manage_Users
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
            this.buttonActivateDeactivate = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.bookId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(965, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonActivateDeactivate
            // 
            this.buttonActivateDeactivate.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActivateDeactivate.Location = new System.Drawing.Point(707, 106);
            this.buttonActivateDeactivate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonActivateDeactivate.Name = "buttonActivateDeactivate";
            this.buttonActivateDeactivate.Size = new System.Drawing.Size(131, 27);
            this.buttonActivateDeactivate.TabIndex = 28;
            this.buttonActivateDeactivate.Text = "Activate/Deactivate";
            this.buttonActivateDeactivate.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(843, 106);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(80, 27);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(406, 110);
            this.textBoxBookName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(200, 24);
            this.textBoxBookName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "User Name";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.Location = new System.Drawing.Point(98, 110);
            this.textBoxBookID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(200, 24);
            this.textBoxBookID.TabIndex = 23;
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.Location = new System.Drawing.Point(39, 110);
            this.bookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(54, 21);
            this.bookId.TabIndex = 22;
            this.bookId.Text = "User ID";
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 571);
            this.Controls.Add(this.buttonActivateDeactivate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Manage_Users";
            this.Load += new System.EventHandler(this.Manage_Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonActivateDeactivate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label bookId;
    }
}