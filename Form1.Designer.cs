namespace SQLINATOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            filePathTextBox = new TextBox();
            sheetNameTextBox = new TextBox();
            tableNameTextBox = new TextBox();
            convertButton = new Button();
            browseButton = new Button();
            sqlTextBox = new TextBox();
            label1 = new Label();
            lblSheetName = new Label();
            lblTableName = new Label();
            btnUpdatePage = new Button();
            SuspendLayout();
            // 
            // filePathTextBox
            // 
            filePathTextBox.AllowDrop = true;
            filePathTextBox.Location = new Point(68, 6);
            filePathTextBox.MaximumSize = new Size(1000, 1000);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(300, 23);
            filePathTextBox.TabIndex = 0;
            // 
            // sheetNameTextBox
            // 
            sheetNameTextBox.Location = new Point(87, 35);
            sheetNameTextBox.Name = "sheetNameTextBox";
            sheetNameTextBox.Size = new Size(300, 23);
            sheetNameTextBox.TabIndex = 1;
            // 
            // tableNameTextBox
            // 
            tableNameTextBox.Location = new Point(85, 64);
            tableNameTextBox.Name = "tableNameTextBox";
            tableNameTextBox.Size = new Size(300, 23);
            tableNameTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(12, 103);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click_1;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(93, 103);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 4;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click_1;
            // 
            // sqlTextBox
            // 
            sqlTextBox.Location = new Point(12, 132);
            sqlTextBox.MinimumSize = new Size(100, 100);
            sqlTextBox.Name = "sqlTextBox";
            sqlTextBox.Size = new Size(700, 100);
            sqlTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "File Path:";
            // 
            // lblSheetName
            // 
            lblSheetName.AutoSize = true;
            lblSheetName.Location = new Point(7, 38);
            lblSheetName.Name = "lblSheetName";
            lblSheetName.Size = new Size(74, 15);
            lblSheetName.TabIndex = 7;
            lblSheetName.Text = "Sheet Name:";
            // 
            // lblTableName
            // 
            lblTableName.AutoSize = true;
            lblTableName.Location = new Point(7, 67);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(72, 15);
            lblTableName.TabIndex = 8;
            lblTableName.Text = "Table Name:";
            // 
            // btnUpdatePage
            // 
            btnUpdatePage.Location = new Point(631, 12);
            btnUpdatePage.Name = "btnUpdatePage";
            btnUpdatePage.Size = new Size(92, 23);
            btnUpdatePage.TabIndex = 9;
            btnUpdatePage.Text = "UPDATINATOR";
            btnUpdatePage.UseVisualStyleBackColor = true;
            btnUpdatePage.Click += btnUpdatePage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 245);
            Controls.Add(btnUpdatePage);
            Controls.Add(lblTableName);
            Controls.Add(lblSheetName);
            Controls.Add(label1);
            Controls.Add(sqlTextBox);
            Controls.Add(browseButton);
            Controls.Add(convertButton);
            Controls.Add(tableNameTextBox);
            Controls.Add(sheetNameTextBox);
            Controls.Add(filePathTextBox);
            Name = "Form1";
            Text = "SQLINATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filePathTextBox;
        private TextBox sheetNameTextBox;
        private TextBox tableNameTextBox;
        private Button convertButton;
        private Button browseButton;
        private TextBox sqlTextBox;
        private Label label1;
        private Label lblSheetName;
        private Label lblTableName;
        private Button btnUpdatePage;
    }
}