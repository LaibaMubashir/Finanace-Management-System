using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finance
{
    public partial class ViewBudgets : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\PUCIT\\7- Seventh Semester\\Enterprise Application Development\\Project\\EAD-Project\\Finance\\Database1.mdf\"";

        public ViewBudgets()
        {
            InitializeComponent();
        }

        private void ViewBudgets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Budgets' table. You can move, or remove it, as needed.
            this.budgetsTableAdapter.Fill(this.database1DataSet.Budgets);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Retrieve the unique identifier of the record to delete (e.g., an ID or key)
                    int recordId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value; // Replace "ID" with the actual column name or property

                    // Perform the deletion in your data source (e.g., a database or list)
                    // Call a function to delete the record from your data source
                    DeleteRecordFromDataSource(recordId);

                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

        }



        private void DeleteRecordFromDataSource(int recordId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Budgets WHERE BudgetID = @BudgetID"; // Replace YourTable with your actual table name

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@BudgetID", recordId);
                    command.ExecuteNonQuery();
                }
            }
        }









    }
}
