using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class budgets : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public budgets()
        {
            InitializeComponent();
            // After adding or updating categories in the database, refresh the DataGridView data
            RefreshTransactionCategoriesInDataGridView();

        }
        private void RefreshTransactionCategoriesInDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TransactionCategories"; // Retrieve all columns

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable categoriesTable = new DataTable();
                    adapter.Fill(categoriesTable);

                    // Update the DataGridView data source with all columns
                    transactionCategoriesBindingSource1.DataSource = categoriesTable;
                }
            }
        }

        private void budgets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet19.TransactionCategories' table. You can move, or remove it, as needed.
            this.transactionCategoriesTableAdapter1.Fill(this.database1DataSet19.TransactionCategories);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
