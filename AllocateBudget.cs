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
    public partial class AllocateBudget : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public AllocateBudget()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllocateBudget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.TransactionCategories' table. You can move, or remove it, as needed.
            this.transactionCategoriesTableAdapter1.Fill(this.database1DataSet11.TransactionCategories);
            // TODO: This line of code loads data into the 'database1DataSet9.TransactionCategories' table. You can move, or remove it, as needed.
            this.transactionCategoriesTableAdapter.Fill(this.database1DataSet9.TransactionCategories);


        }
        private void InsertOrUpdateBudgetAmount(string department, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Begin a SQL transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update or insert the budget amount in the TransactionCategories table
                    string updateQuery = "UPDATE TransactionCategories SET amount = amount + @amount WHERE CategoryName = @department";
                    string insertQuery = "INSERT INTO TransactionCategories (CategoryName, amount) VALUES (@department, @amount)";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@department", department);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            command.CommandText = insertQuery;
                            command.ExecuteNonQuery();
                        }
                    }

                    // Log the budget allocation/update in the Financial Transaction table
                    string logQuery = "INSERT INTO FinancialTransactions (user_id,username,TransactionType, TransactionDate, Amount, Description) " +
                        "VALUES (1,@username,@transactionType, @transactionDate, @amount, @description)";

                    using (SqlCommand logCommand = new SqlCommand(logQuery, connection, transaction))
                    {
                        logCommand.Parameters.AddWithValue("@transactionType", "Budget Added");
                        logCommand.Parameters.AddWithValue("@username", "ADMIN");
                        logCommand.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                        logCommand.Parameters.AddWithValue("@amount", amount);
                        logCommand.Parameters.AddWithValue("@description", $"Budget allocation/update for {department}");

                        logCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction if everything succeeded
                    transaction.Commit();
                    MessageBox.Show("Budget amount updated or inserted successfully. Log created in Financial Transactions.");
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if there's an error
                    transaction.Rollback();
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string department = null;
            if (comboBoxDepartment.SelectedItem != null)
            {
                DataRowView selectedRow = comboBoxDepartment.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    department = selectedRow["CategoryName"].ToString();

                    // Use the selected value as needed
                }
            }

            Console.WriteLine(department);
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                InsertOrUpdateBudgetAmount(department, amount);
                MessageBox.Show("Budget amount updated or inserted successfully.");
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid numeric amount.");
            }
        }
        
    }
}
