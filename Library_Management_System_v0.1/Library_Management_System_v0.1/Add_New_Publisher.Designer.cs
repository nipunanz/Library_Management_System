namespace Library_Management_System_v0._1
{
    partial class Add_New_Publisher
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
            this.buttonSavePublisher = new System.Windows.Forms.Button();
            this.textBoxAddPublisher = new System.Windows.Forms.TextBox();
            this.publisherName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPublisherDescp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSavePublisher
            // 
            this.buttonSavePublisher.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePublisher.Location = new System.Drawing.Point(232, 296);
            this.buttonSavePublisher.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSavePublisher.Name = "buttonSavePublisher";
            this.buttonSavePublisher.Size = new System.Drawing.Size(112, 38);
            this.buttonSavePublisher.TabIndex = 32;
            this.buttonSavePublisher.Text = "Save";
            this.buttonSavePublisher.UseVisualStyleBackColor = true;
            this.buttonSavePublisher.Click += new System.EventHandler(this.buttonSavePublisher_Click);
            // 
            // textBoxAddPublisher
            // 
            this.textBoxAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddPublisher.Location = new System.Drawing.Point(226, 129);
            this.textBoxAddPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddPublisher.Name = "textBoxAddPublisher";
            this.textBoxAddPublisher.Size = new System.Drawing.Size(273, 28);
            this.textBoxAddPublisher.TabIndex = 31;
            // 
            // publisherName
            // 
            this.publisherName.AutoSize = true;
            this.publisherName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherName.Location = new System.Drawing.Point(68, 128);
            this.publisherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(149, 29);
            this.publisherName.TabIndex = 30;
            this.publisherName.Text = "Publisher Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 59);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add New Publisher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPublisherDescp
            // 
            this.textBoxPublisherDescp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherDescp.Location = new System.Drawing.Point(226, 172);
            this.textBoxPublisherDescp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublisherDescp.Multiline = true;
            this.textBoxPublisherDescp.Name = "textBoxPublisherDescp";
            this.textBoxPublisherDescp.Size = new System.Drawing.Size(273, 111);
            this.textBoxPublisherDescp.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Description";
            // 
            // Add_New_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.textBoxPublisherDescp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSavePublisher);
            this.Controls.Add(this.textBoxAddPublisher);
            this.Controls.Add(this.publisherName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_New_Publisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSavePublisher;
        private System.Windows.Forms.TextBox textBoxAddPublisher;
        private System.Windows.Forms.Label publisherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPublisherDescp;
        private System.Windows.Forms.Label label2;
    }
}