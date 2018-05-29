namespace Library_Management_System_v0._1
{
    partial class Add_New_Author
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
            this.buttonSaveAuthor = new System.Windows.Forms.Button();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthorDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveAuthor
            // 
            this.buttonSaveAuthor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSaveAuthor.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveAuthor.Location = new System.Drawing.Point(311, 364);
            this.buttonSaveAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveAuthor.Name = "buttonSaveAuthor";
            this.buttonSaveAuthor.Size = new System.Drawing.Size(149, 55);
            this.buttonSaveAuthor.TabIndex = 28;
            this.buttonSaveAuthor.Text = "Save";
            this.buttonSaveAuthor.UseVisualStyleBackColor = false;
            this.buttonSaveAuthor.Click += new System.EventHandler(this.buttonSaveAuthor_Click);
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddAuthor.Location = new System.Drawing.Point(303, 149);
            this.textBoxAddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(363, 34);
            this.textBoxAddAuthor.TabIndex = 27;
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(92, 148);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(163, 37);
            this.authorName.TabIndex = 26;
            this.authorName.Text = "Author Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 73);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add New Author";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // textBoxAuthorDescription
            // 
            this.textBoxAuthorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorDescription.Location = new System.Drawing.Point(303, 208);
            this.textBoxAuthorDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthorDescription.Multiline = true;
            this.textBoxAuthorDescription.Name = "textBoxAuthorDescription";
            this.textBoxAuthorDescription.Size = new System.Drawing.Size(363, 136);
            this.textBoxAuthorDescription.TabIndex = 30;
            // 
            // Add_New_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.textBoxAuthorDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveAuthor);
            this.Controls.Add(this.textBoxAddAuthor);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_New_Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveAuthor;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthorDescription;
    }
}