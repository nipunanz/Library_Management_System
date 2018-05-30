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
            this.textBoxPublisherDescp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSavePublisher
            // 
            this.buttonSavePublisher.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSavePublisher.Font = new System.Drawing.Font("Roboto Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePublisher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSavePublisher.Location = new System.Drawing.Point(313, 372);
            this.buttonSavePublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSavePublisher.Name = "buttonSavePublisher";
            this.buttonSavePublisher.Size = new System.Drawing.Size(149, 54);
            this.buttonSavePublisher.TabIndex = 32;
            this.buttonSavePublisher.Text = "Save";
            this.buttonSavePublisher.UseVisualStyleBackColor = false;
            this.buttonSavePublisher.Click += new System.EventHandler(this.buttonSavePublisher_Click);
            // 
            // textBoxAddPublisher
            // 
            this.textBoxAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddPublisher.Location = new System.Drawing.Point(301, 155);
            this.textBoxAddPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddPublisher.Name = "textBoxAddPublisher";
            this.textBoxAddPublisher.Size = new System.Drawing.Size(363, 34);
            this.textBoxAddPublisher.TabIndex = 31;
            // 
            // publisherName
            // 
            this.publisherName.AutoSize = true;
            this.publisherName.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherName.Location = new System.Drawing.Point(91, 154);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(190, 37);
            this.publisherName.TabIndex = 30;
            this.publisherName.Text = "Publisher Name";
            // 
            // textBoxPublisherDescp
            // 
            this.textBoxPublisherDescp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisherDescp.Location = new System.Drawing.Point(301, 208);
            this.textBoxPublisherDescp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPublisherDescp.Multiline = true;
            this.textBoxPublisherDescp.Name = "textBoxPublisherDescp";
            this.textBoxPublisherDescp.Size = new System.Drawing.Size(363, 136);
            this.textBoxPublisherDescp.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(-5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 73);
            this.label3.TabIndex = 35;
            this.label3.Text = "Add New Publisher";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_New_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPublisherDescp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSavePublisher);
            this.Controls.Add(this.textBoxAddPublisher);
            this.Controls.Add(this.publisherName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_New_Publisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSavePublisher;
        private System.Windows.Forms.TextBox textBoxAddPublisher;
        private System.Windows.Forms.Label publisherName;
        private System.Windows.Forms.TextBox textBoxPublisherDescp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}