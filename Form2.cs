using Microsoft.Office.Interop.Excel;

namespace SQLINATOR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void browseButton_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInsertPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an Excel file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Open the Excel file
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Open(txtFilePath.Text);
                var worksheet = (Worksheet)workbook.Sheets[1];

                // Get the number of rows and columns
                var rows = worksheet.UsedRange.Rows.Count;
                var cols = worksheet.UsedRange.Columns.Count;

                // Get the column names from the first row of the Excel sheet
                var columnNames = new string[cols];
                for (var i = 1; i <= cols; i++)
                {
                    columnNames[i - 1] = ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i]).Value2.ToString();
                }

                // Generate the SQL update statements
                var sqlStatements = ""; //sql variable
                for (var i = 2; i <= rows; i++) //while i != no. of rows left to process. 
                {
                    sqlStatements += "UPDATE " + txtTableName.Text + " SET ";
                    for (var j = 2; j <= cols; j++) //while j!= no. of columns left to process.
                    {
                        var columnName = columnNames[j - 1];
                        var cellValue = ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, j]).Value2;
                        if (cellValue != null)
                        {
                            sqlStatements += txtFieldName.Text + " = '" + cellValue.ToString() + "', ";
                        }
                        else
                        {
                            sqlStatements += txtFieldName.Text + " = NULL, ";
                        }
                    }
                    sqlStatements = sqlStatements.Remove(sqlStatements.Length - 2); // Remove the last comma and space
                    sqlStatements += "WHERE " + txtFieldName.Text + " = '" + ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i, 1]).Value2.ToString() + "';" + Environment.NewLine;
                }

                // Close the Excel file
                workbook.Close(false);
                excelApp.Quit();

                // Output the SQL statements
                txtSqlStatements.Text = sqlStatements;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
