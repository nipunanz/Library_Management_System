namespace Library_Management_System_v0._1
{
    partial class Edit_Author
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(218, 141);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(273, 25);
            this.comboBoxCategory.TabIndex = 36;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Author";
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCategory.Location = new System.Drawing.Point(224, 296);
            this.buttonSaveCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(112, 38);
            this.buttonSaveCategory.TabIndex = 34;
            this.buttonSaveCategory.Text = "Update";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            this.buttonSaveCategory.Click += new System.EventHandler(this.buttonSaveCategory_Click);
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddCategory.Location = new System.Drawing.Point(218, 195);
            this.textBoxAddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(273, 28);
            this.textBoxAddCategory.TabIndex = 33;
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(59, 193);
            this.categoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(147, 25);
            this.categoryName.TabIndex = 32;
            this.categoryName.Text = "New Author Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 59);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edit Author";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveCategory);
            this.Controls.Add(this.textBoxAddCategory);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Edit_Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveCategory;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.Label label1;
    }
}