namespace Library_Management_System_v0._1
{
    partial class Add_New_Category
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
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddCategory.Location = new System.Drawing.Point(304, 205);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(363, 34);
            this.textBoxAddCategory.TabIndex = 8;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(93, 203);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(186, 37);
            this.categoryName.TabIndex = 7;
            this.categoryName.Text = "Category Name";
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCategory.Location = new System.Drawing.Point(312, 363);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(149, 47);
            this.buttonSaveCategory.TabIndex = 24;
            this.buttonSaveCategory.Text = "Save";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            this.buttonSaveCategory.Click += new System.EventHandler(this.buttonSaveCategory_Click);
            // 
            // Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.buttonSaveCategory);
            this.Controls.Add(this.textBoxAddCategory);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.Button buttonSaveCategory;
    }
}