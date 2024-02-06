namespace SQLINATOR
{
    partial class Form2
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
            label1 = new Label();
            txtSqlStatements = new TextBox();
            btnGenerate = new Button();
            txtFilePath = new TextBox();
            btnInsertPage = new Button();
            lblTableName = new Label();
            lblFieldName = new Label();
            txtTableName = new TextBox();
            txtFieldName = new TextBox();
            btnBrowse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 15;
            label1.Text = "File Path:";
            // 
            // txtSqlStatements
            // 
            txtSqlStatements.Location = new Point(12, 144);
            txtSqlStatements.MinimumSize = new Size(100, 100);
            txtSqlStatements.Name = "txtSqlStatements";
            txtSqlStatements.Size = new Size(700, 100);
            txtSqlStatements.TabIndex = 14;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 105);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Convert";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click_1;
            // 
            // txtFilePath
            // 
            txtFilePath.AllowDrop = true;
            txtFilePath.Location = new Point(73, 6);
            txtFilePath.MaximumSize = new Size(1000, 1000);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(300, 23);
            txtFilePath.TabIndex = 9;
            // 
            // btnInsertPage
            // 
            btnInsertPage.Location = new Point(630, 9);
            btnInsertPage.Name = "btnInsertPage";
            btnInsertPage.Size = new Size(92, 23);
            btnInsertPage.TabIndex = 16;
            btnInsertPage.Text = "INSERTINATOR";
            btnInsertPage.UseVisualStyleBackColor = true;
            btnInsertPage.Click += btnInsertPage_Click;
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Location = new Point(12, 67);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(72, 15);
            lblTableName.TabIndex = 20;
            lblTableName.Text = "Table Name:";
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new Point(10, 38);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new Size(70, 15);
            lblFieldName.TabIndex = 19;
            lblFieldName.Text = "Field Name:";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(90, 64);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(300, 23);
            txtTableName.TabIndex = 18;
            // 
            // txtFieldName
            // 
            txtFieldName.Location = new Point(90, 35);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.Size = new Size(300, 23);
            txtFieldName.TabIndex = 17;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(93, 105);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 262);
            Controls.Add(btnBrowse);
            Controls.Add(lblTableName);
            Controls.Add(lblFieldName);
            Controls.Add(txtTableName);
            Controls.Add(txtFieldName);
            Controls.Add(btnInsertPage);
            Controls.Add(label1);
            Controls.Add(txtSqlStatements);
            Controls.Add(btnGenerate);
            Controls.Add(txtFilePath);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSqlStatements;
        private Button btnGenerate;
        private TextBox txtFilePath;
        private Button btnInsertPage;
        private Label lblTableName;
        private Label lblFieldName;
        private TextBox txtTableName;
        private TextBox txtFieldName;
        private Button btnBrowse;
    }
}