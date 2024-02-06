using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SQLINATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click_1(object sender, EventArgs e)
        {
            {
                // Check if a file is selected
                if (string.IsNullOrWhiteSpace(filePathTextBox.Text))
                {
                    MessageBox.Show("Please select an Excel file.");
                    return;
                }

                // Read data from the Excel file
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePathTextBox.Text};Extended Properties=\"Excel 12.0;HDR=YES;\"";
                string selectCommand = $"SELECT * FROM [{sheetNameTextBox.Text}$]";
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand, connectionString);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Generate SQL insert statement
                string tableName = tableNameTextBox.Text;
                string columns = string.Join(",", table.Columns.Cast<DataColumn>().Select(c => $"[{c.ColumnName}]"));
                string values = string.Join(",", table.Rows.Cast<DataRow>().Select(r => $"({string.Join(",", r.ItemArray.Select(i => $"'{i.ToString().Replace("'", "''")}'"))})"));
                string insertStatement = $"INSERT INTO [{tableName}] ({columns}) VALUES {values};";

                // Display the SQL insert statement
                sqlTextBox.Text = insertStatement;
            }
        }

        private void browseButton_Click_1(object sender, EventArgs e)
        {
            // Open a file dialog to select an Excel file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void btnUpdatePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}