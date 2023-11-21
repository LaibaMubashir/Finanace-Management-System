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
    public partial class transactions : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public transactions()
        {

            InitializeComponent();
            RefreshData();
        }
        private void RefreshData()
        {
            try
            {
                
                // Your SQL query to fetch data from the FinancialTransactions table
                string query = "SELECT * FROM FinancialTransactions";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable categoriesTable = new DataTable();
                        adapter.Fill(categoriesTable);

                        // Update the DataGridView data source with all columns
                        financialTransactionsBindingSource.DataSource = categoriesTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet21.FinancialTransactions' table. You can move, or remove it, as needed.
            this.financialTransactionsTableAdapter.Fill(this.database1DataSet21.FinancialTransactions);

        }

        private void button2_Click(object sender, EventArgs e)
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
